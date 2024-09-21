using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class MainMembers : Form
	{
		// Connection string for the SQL Server database
		private string connectionString = "Server=.;Database=LibraryManagementSystem;Trusted_Connection=True;TrustServerCertificate=True";

		// Constructor for MainMembers form
		public MainMembers()
		{
			InitializeComponent();
			// Load members when the form is shown
			this.Shown += Member_Form;
		}

		// Event handler to load the members into the DataGridView when the form is shown
		private void Member_Form(object sender, EventArgs e)
		{
			memberView.DataSource = memberGet_Data();
		}

		// Method to retrieve member data from the database based on search criteria
		public List<Members> memberGet_Data()
		{
			List<Members> members = new List<Members>();
			string query = "SELECT MemberID, FirstName, LastName, Email, PhoneNumber, JoinDate FROM Members WHERE 1=1";

			// Preparing search criteria
			string name = $"%{NameText.Text}%";
			string id = IDSearchText.Text;
			List<SqlParameter> parameters = new List<SqlParameter>();

			// Adding search filters to the query
			if (!string.IsNullOrWhiteSpace(NameText.Text))
			{
				query += " AND FirstName LIKE @name";
				parameters.Add(new SqlParameter("@name", name));
			}
			if (!string.IsNullOrWhiteSpace(IDSearchText.Text))
			{
				query += " AND MemberID = @id";
				parameters.Add(new SqlParameter("@id", Convert.ToInt32(id)));
			}

			// Connecting to the database and executing the query
			using (SqlConnection con = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(query, con))
			{
				cmd.Parameters.AddRange(parameters.ToArray());
				con.Open();

				// Reading the data from the database
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						members.Add(new Members()
						{
							MembersID = Convert.ToInt32(reader["MemberID"]),
							FirstName = reader["FirstName"].ToString(),
							LastName = reader["LastName"].ToString(),
							Email = reader["Email"].ToString(),
							PhoneNumber = reader["PhoneNumber"].ToString(),
							JoinDate = (DateTime)reader["JoinDate"]
						});
					}
				}
			}

			return members;
		}

		// Event handler for searching members based on the criteria
		private void btnSearch_Click(object sender, EventArgs e)
		{
			memberView.DataSource = memberGet_Data();
		}

		// Event handler for adding a new member
		private void btnADD_Click(object sender, EventArgs e)
		{
			MemberManagment addForm = new MemberManagment();
			addForm.SetData += SetData_Form;
			addForm.Show();
		}

		// Event handler for editing the selected member
		private void btnEdite_Click(object sender, EventArgs e)
		{
			var SelectedMember = memberView.CurrentRow.DataBoundItem as Members;

			if (SelectedMember != null)
			{
				MemberManagment editForm = new MemberManagment(SelectedMember);
				editForm.SetData += SetData_Form;
				editForm.Show();
			}
			else
			{
				MessageBox.Show("Please select a member to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// Event handler for deleting the selected member
		private void btnDelete_Click(object sender, EventArgs e)
		{
			var SelectedMember = memberView.CurrentRow.DataBoundItem as Members;

			if (SelectedMember != null)
			{
				var result = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					MemberManagment editForm = new MemberManagment(SelectedMember);
					editForm.Delete_Member(SelectedMember);
					editForm.SetData += SetData_Form;
					memberView.DataSource = memberGet_Data();
				}
			}
			else
			{
				MessageBox.Show("Please select a member to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// Event handler to update the member data in the DataGridView after an insert, update, or delete operation
		private void SetData_Form()
		{
			memberView.DataSource = memberGet_Data();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Form form = new Main();
			form.Show();
			this.Hide();
		}
	}
}
