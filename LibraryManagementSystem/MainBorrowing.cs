using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class MainBorrowing : Form
	{
		string connectionString = "Server=.;Database=LibraryManagementSystem;Trusted_Connection=True;TrustServerCertificate=True";
		BindingSource bindingSource;

		bool Clicked = false; // Boolean to track if the Overdue button has been clicked

		// Constructor for MainBorrowing form
		public MainBorrowing()
		{
			InitializeComponent();
			this.Shown += Data_BorrowView;

			// Bind the Borrowings class to the BindingSource
			bindingSource = new BindingSource();
			Borrowings b = new Borrowings();
			bindingSource.DataSource = b;


			// Load the members into the ComboBox
			LoadMemeber();

			// Bind the SelectedValue of the ComboBox to the MemberID property of the Borrowings object
			BmemberList.ComboBox.DataBindings.Add("SelectedValue" , bindingSource , nameof(b.MemberID));

		}

		// Event handler to load the borrowing data into the DataGridView when the form is shown
		private void Data_BorrowView(object sender, EventArgs e)
		{
			BorrowView.DataSource = Borrow_Data();
		}

		// Event handler for the search button to reload the borrowing data
		private void btnMBorrow_Click(object sender, EventArgs e)
		{
			BorrowView.DataSource = Borrow_Data();

			LoadMemeber() ;
		}

		// Event handler to open the BorrowManagement form for borrowing a new book
		private void btnBorrow_Click(object sender, EventArgs e)
		{
			BorrowManagment borrowManagmentForm = new BorrowManagment();
			borrowManagmentForm.DataSet += Form_SetData;
			borrowManagmentForm.Show();
		}

		// Event handler to return a borrowed book and to set the ReturnDate in BorrowManagment
		private void btnReturn_Click(object sender, EventArgs e)
		{
			Borrowings SelectedBorrow = BorrowView.CurrentRow.DataBoundItem as Borrowings;

			if (SelectedBorrow != null)
			{
				BorrowManagment borrowManagement = new BorrowManagment(SelectedBorrow);
				borrowManagement.Return_Book(SelectedBorrow);
				borrowManagement.DataSet += Form_SetData;
				BorrowView.DataSource = Borrow_Data();
			}
			else
			{
				MessageBox.Show("Please select a borrowing record to return.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// Event handler to filter and show only overdue borrowings
		private void btnOverDue_Click(object sender, EventArgs e)
		{
			Clicked = true;
			BorrowView.DataSource = Borrow_Data();
		}

		// Method to retrieve borrowing data from the database based on the selected filters
		public List<Borrowings> Borrow_Data()
		{
			//string Query = "Select * From Borrowings";
			string query = "Select BorrowID, B.BookID, Title , B.MemberID, FirstName, BorrowDate, DueDate, ReturnDate " +
						   "From Borrowings B join Book Bo on B.BookID=Bo.BookID " +
						   "join Members M on B.MemberID=M.MemberID where 1=1";

			List<Borrowings> borrow = new List<Borrowings>();
			List<SqlParameter> sp = new List<SqlParameter>();

			// Filter by selected member if a member is selected
			if (BmemberList.ComboBox.SelectedIndex != -1)
			{
				int mID = Convert.ToInt32(BmemberList.ComboBox.SelectedValue);
				query += " AND B.MemberID = @MemberID";
				sp.Add(new SqlParameter("@MemberId",mID));
			}

			// Filter by overdue books if the Overdue button was clicked
			if (Clicked == true)
			{
				query += " AND DueDate < @CurrentDate ";
				sp.Add(new SqlParameter("@CurrentDate", DateTime.Now));
			}

			// Execute the query and read the results
			using (SqlConnection conn = new SqlConnection(connectionString))
			using(SqlCommand cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddRange(sp.ToArray());
				conn.Open();
				using(SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						borrow.Add(new Borrowings()
						{
							BorrowID = Convert.ToInt32(reader["BorrowID"]),
							BookID = Convert.ToInt32(reader["BookID"]),
							BookName = reader["Title"].ToString(),
							MemberID = Convert.ToInt32(reader["MemberID"]),
							MemberName = reader["FirstName"].ToString(),
							BorrowDate = (DateTime)reader["BorrowDate"],
							DueDate = (DateTime)reader["DueDate"],
							ReturnDate =(reader["ReturnDate"] != DBNull.Value ? (DateTime?)reader["ReturnDate"] : null)

						});

					}
				}
				return borrow;
			}
		}

		// Method to load distinct members who have borrowed books into the ComboBox
		public void LoadMemeber()
		{
			string query = "Select Distinct B.MemberID , M.FirstName " +
						   "From Members M join Borrowings B " +
						   "on M.MemberID = B.MemberID";
			List<Members> members = new List<Members>();
			using(SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				conn.Open();
				using(SqlDataReader r = cmd.ExecuteReader())
				{
					while (r.Read())
					{
						members.Add(new Members()
						{
							MembersID = Convert.ToInt32(r["MemberID"]),
							FirstName = r["FirstName"].ToString()
						});
					}
				}
			}
			// Bind the members list to the ComboBox
			BmemberList.ComboBox.DataSource = members;
			BmemberList.ComboBox.DisplayMember = "FirstName";
			BmemberList.ComboBox.ValueMember = "MembersID";

		}

		// Event handler to refresh the borrowing data in the DataGridView after an operation
		private void Form_SetData()
		{
			BorrowView.DataSource = Borrow_Data();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Form form = new Main();
			form.Show();
			this.Hide();
		}
	}
}
