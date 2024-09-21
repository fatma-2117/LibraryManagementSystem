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
using System.Windows.Forms.VisualStyles;

namespace LibraryManagementSystem
{
	public partial class MemberManagment : Form
	{
		// Connection string for the SQL Server database
		string connectionString = "Server=.;Database=LibraryManagementSystem;Trusted_Connection=True;TrustServerCertificate=True";
		public BindingSource binding;
		public event Action SetData;    // Event triggered when data is set or updated

		// Constructor that accepts a Members object
		public MemberManagment(Members member) : this()
		{
			binding.DataSource = member;// Set the data source of the binding to the passed Members object
		}

		// Default constructor
		public MemberManagment()
		{
			InitializeComponent();
			binding = new BindingSource();

			// Initialize a new Members object and set it as the binding source
			Members member = new Members();
			binding.DataSource = member;

			// Data binding for the text fields
			IdText.DataBindings.Add("Text", binding, nameof(member.MembersID), true, DataSourceUpdateMode.Never);
			FNameText.DataBindings.Add("Text", binding, "FirstName");
			LNameText.DataBindings.Add("Text", binding, "LastName");
			EmailText.DataBindings.Add("Text", binding, "Email");
			PhoneText.DataBindings.Add("Text", binding, "PhoneNumber");
			JoinDateText.DataBindings.Add("Text", binding, "JoinDate");


		}

		// Save button click event handler
		private void btnSave_Click(object sender, EventArgs e)
		{
			// Validate form inputs before saving data
			if (IsValidForm())
			{
				Members member = binding.Current as Members;
				if (member.MembersID == 0)    // to insert new member
				{
					Insert_Member(member);
				}
				else
				{
					Update_Member(member);    // to update existing member
				}
				SetData?.Invoke();    // Trigger any attached event handlers
				this.Hide();
			}
			else
			{
				MessageBox.Show("Please complete all fields correctly.", "Form Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// Validates the form input
		private bool IsValidForm()
		{
			return !string.IsNullOrWhiteSpace(FNameText.Text) &&
				   !string.IsNullOrWhiteSpace(LNameText.Text) &&
				   !string.IsNullOrWhiteSpace(EmailText.Text) &&
				   PhoneText.Text.Length == 11 &&
				   JoinDateText.Text != "1/1/0001 12:00:00 AM";
		}

		// Inserts a new member into the database
		public void Insert_Member(Members member)
		{
			// SQL query to insert a new member and return the new MemberID
			string query = "INSERT INTO Members(FirstName, LastName, Email, PhoneNumber, JoinDate)" +
						  "Values(@FirstName, @LastName, @Email, @PhoneNumber, @JoinDate);" +
						  "Select SCOPE_IDENTITY();";
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				using (SqlCommand command = new SqlCommand(query, sqlConnection))
				{
					// Add parameters to the SQL command
					command.Parameters.AddWithValue("@FirstName", member.FirstName);
					command.Parameters.AddWithValue("@LastName", member.LastName);
					command.Parameters.AddWithValue("@Email", member.Email);
					command.Parameters.AddWithValue("@PhoneNumber", member.PhoneNumber);
					command.Parameters.AddWithValue("@JoinDate", member.JoinDate);

					sqlConnection.Open();

					// Execute the query and retrieve the new member's ID
					int id = Convert.ToInt32(command.ExecuteScalar());
					member.MembersID = id;
					MessageBox.Show("The member was added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					binding.ResetBindings(false); // Refresh the bindings to reflect the changes in the UI
					IdText.Refresh();
				}

			}
							
		}

		// Updates an existing member in the database
		public void Update_Member(Members member)
		{
			string query = "UPDATE Members SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, JoinDate = @JoinDate " +
						   "From Members Where MemberID = @MemberID";
			using(SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				using(SqlCommand command = new SqlCommand(query, sqlConnection))
				{
					// Add parameters to the SQL command
					command.Parameters.AddWithValue("@FirstName", member.FirstName);
					command.Parameters.AddWithValue("@LastName", member.LastName);
					command.Parameters.AddWithValue("@Email", member.Email);
					command.Parameters.AddWithValue("@PhoneNumber", member.PhoneNumber);
					command.Parameters.AddWithValue("@JoinDate", member.JoinDate);
					command.Parameters.AddWithValue("@MemberID", member.MembersID);

					sqlConnection.Open();

					command.ExecuteScalar();// Execute the query to update the book record

					MessageBox.Show("The member was updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					binding.ResetBindings(false);
					IdText.Refresh();
				}
			}
		}

		// Deletes a member from the database
		public void Delete_Member(Members member)
		{
			string query = "Delete From Members Where MemberID = @MemberID";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@MemberID", member.MembersID);
					connection.Open();
					command.ExecuteNonQuery();
				}
			}
		}
	}
}
