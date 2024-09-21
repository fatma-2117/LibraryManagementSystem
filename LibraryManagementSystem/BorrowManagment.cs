using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class BorrowManagment : Form
	{
		string connectionString = "Server=.;Database=LibraryManagementSystem;Trusted_Connection=True;TrustServerCertificate=True";
		BindingSource binding;
		public event Action DataSet;

		public BorrowManagment(Borrowings borrowings): this()
		{
			binding.DataSource = borrowings;
		}


		public BorrowManagment()
		{
			InitializeComponent();
			binding =new BindingSource();
			Borrowings borrowings = new Borrowings();
			binding.DataSource = borrowings;

			// Data binding for text fields and combo boxes
			IDText.DataBindings.Add("Text", binding, nameof(borrowings.BorrowID), true, DataSourceUpdateMode.Never);
			LoadBook();
			BookList.DataBindings.Add("SelectedValue", binding, nameof(borrowings.BookID));
			LoadMember();
			MemberList.DataBindings.Add("SelectedValue",binding, nameof(borrowings.MemberID));



		}

		// Loads available books into the BookList combo box
		public void LoadBook()
		{
			string query = "Select BookID, Title From Book  where AvailableCopies > 0";
			List<Book> books = new List<Book>();
			using(SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				conn.Open();
				using(SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{

						books.Add(new Book()      // Adding each book to the list
						{
							BookID = Convert.ToInt32(reader["BookID"]),
							Title = Convert.ToString(reader["Title"]),
						});
					}
				}
			}
			// Setting the data source for the BookList combo box
			BookList.DataSource = books;
			BookList.DisplayMember = "Title"; // Setting the data that will show as Title
			BookList.ValueMember = "BookID"; // Setting th value of the selection as BookID
		}

		// Loads members into the MemberList combo box
		public void LoadMember()
		{
			string query = "Select MemberID, FirstName From Members";
			List<Members> members = new List<Members>();
			using(SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(query,conn))
			{
				conn.Open() ;
				using(SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						members.Add(new Members()
						{
							MembersID = Convert.ToInt32(reader["MemberID"]),
							FirstName = reader["FirstName"].ToString()
						});
					}
				}
			}
			MemberList.DataSource = members;
			MemberList.DisplayMember = "FirstName";
			MemberList.ValueMember = "MembersID";
		}

		// Save button click event handler
		private void btnSave_Click(object sender, EventArgs e)
		{
			// Check if a book and a member are selected
			if (BookList.SelectedIndex != -1 && MemberList.SelectedIndex != -1)
			{
				Borrowings borrowings = binding.Current as Borrowings;
				// Insert a new borrowing record if the id == 0
				if (borrowings.BorrowID == 0)
				{
					Insert_Borrow(borrowings);
				}
				else
				{
					MessageBox.Show("This book has already been borrowed!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				DataSet?.Invoke();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Please select both a book and a member.", "Selection Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// Inserts a new borrowing record into the database
		public void Insert_Borrow(Borrowings borrowings)
		{
			string query = "INSERT INTO Borrowings(BookID, MemberID, BorrowDate, DueDate) " +
				"Values(@BookID, @MemberID, @BorrowDate, @DueDate);" +
				"Update Book Set AvailableCopies = AvailableCopies-1 WHERE BookID = @BookID; " +
				"Select SCOPE_IDENTITY(); ";

			using(SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				// Adding parameters to the SQL command
				cmd.Parameters.Add("@BookID", borrowings.BookID);
				cmd.Parameters.Add("@MemberID", borrowings.MemberID);
				cmd.Parameters.Add("@BorrowDate", borrowings.SetCurrentDate());
				cmd.Parameters.Add("@DueDate", borrowings.generateDueDate());

				conn.Open() ;

				// Execute the query and retrieve the new borrowing ID
				int id = Convert.ToInt32(cmd.ExecuteScalar());
				borrowings.BorrowID = id;

				MessageBox.Show("The borrowing process was completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				binding.ResetBindings(false);
				IDText.Refresh();

			}
		}

		// Returns a borrowed book and updates the AvailableCopies in the Book and Set the ReturnDate in Borrowings
		public void Return_Book(Borrowings borrowing)
		{
			string query = "UPDATE Book Set AvailableCopies = AvailableCopies+1 where BookID = @BookID; " +
						   "UPDATE Borrowings SET ReturnDate = @ReturnDate Where BorrowID = @BorrowID ; ";
			
			using(SqlConnection conn = new SqlConnection(connectionString))
			using(SqlCommand cmd = new SqlCommand(query, conn))
			{
				// Adding parameters to the SQL command
				cmd.Parameters.AddWithValue("@BookID", borrowing.BookID);
				cmd.Parameters.AddWithValue("@ReturnDate", borrowing.SetCurrentDate());
				cmd.Parameters.AddWithValue("@BorrowID", borrowing.BorrowID);

				conn.Open() ;

				cmd.ExecuteNonQuery(); // Execute the query to update the database 
			}
		}

	}
}
