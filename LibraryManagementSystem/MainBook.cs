using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class MainBook : Form
	{
		// Connection string for the SQL Server database
		string connectionString = "Server=.;Database=LibraryManagementSystem;Trusted_Connection=True;TrustServerCertificate=True";
		BindingSource bindingSource;
		// Constructor for MainBook form
		public MainBook()
		{
			InitializeComponent();
			// Load books when the form is shown
			this.Shown += Book_Form;

			bindingSource = new BindingSource();
			Book book = new Book();
			bindingSource.DataSource = book;

			LoadCategory();

			CategoryType.ComboBox.DataBindings.Add("SelectedValue", bindingSource, nameof(book.CategoryID));
		}

		// Event handler to load the books into the DataGridView when the form is shown
		private void Book_Form(object sender, EventArgs e)
		{
			bookView.DataSource = GetData_Books();
		}

		// Loads categories into the CategoryList combo box
		public void LoadCategory()
		{
			string query = "Select * From Categories";
			List<Categories> categories = new List<Categories>();
			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				connection.Open();
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						categories.Add(new Categories()
						{
							CategoryID = Convert.ToInt32(reader["CategoryID"]),
							CategoryName = reader["CategoryName"].ToString()
						});
					}
				}
			}
			// Loads categories into the CategoryType combo box
			CategoryType.ComboBox.DataSource = categories;
			CategoryType.ComboBox.DisplayMember = "CategoryName";
			CategoryType.ComboBox.ValueMember = "CategoryID";
		}



		// Event handler for editing the selected book
		private void Edite_Click(object sender, EventArgs e)
		{
			var SelectedBook = bookView.CurrentRow.DataBoundItem as Book;

			if (SelectedBook != null)
			{
				BookManagement bookManagement = new BookManagement(SelectedBook);
				bookManagement.DataSet += Form_DataUpdat;
				bookManagement.Show();
			}
			else
			{
				MessageBox.Show("Please select a book to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// Event handler for adding a new book
		private void Add_Click(object sender, EventArgs e)
		{
			BookManagement bookManagement = new BookManagement();
			bookManagement.DataSet += Form_DataUpdat;
			bookManagement.Show();
		}

		// Event handler for deleting the selected book
		private void btnDelete_Click(object sender, EventArgs e)
		{
			var SelectedBook = bookView.CurrentRow.DataBoundItem as Book;

			if (SelectedBook != null)
			{
				var res = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (res == DialogResult.Yes)
				{
					BookManagement bookManagement = new BookManagement(SelectedBook);
					bookManagement.Delete_Book(SelectedBook);
					bookManagement.DataSet += Form_DataUpdat;
					bookView.DataSource = GetData_Books();
				}
			}
			else
			{
				MessageBox.Show("Please select a book to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// Event handler for searching books based on the criteria
		private void btnSearch_Click(object sender, EventArgs e)
		{
			bookView.DataSource = GetData_Books();
		}
		// Event handler to filter the books by it's Category Type 
		private void btnCategoryType_Click(object sender, EventArgs e)
		{
			bookView.DataSource = GetData_Books();

		}

		// Event handler to update the book data in the DataGridView after an insert, update, or delete operation
		private void Form_DataUpdat()
		{
			bookView.DataSource = GetData_Books();
		}

		// Method to retrieve book data from the database based on search criteria
		public List<object> GetData_Books()
		{
			// Base query for retrieving books
			string query = "SELECT * FROM Book B JOIN Categories C ON B.CategoryID = C.CategoryID WHERE 1=1";
			List<object> bookData = new List<object>();
			List<SqlParameter> parameters = new List<SqlParameter>();

			// Preparing search criteria
			string sTitle = $"%{STitleText.Text}%";
			string sAuthor = $"%{SAuthorText.Text}%";
			string sISBN = $"%{SISBNText.Text}%";

			// Filter by selected Category if a Category Name is selected
			if (CategoryType.ComboBox.SelectedIndex != -1)
			{
				int CID = Convert.ToInt32(CategoryType.ComboBox.SelectedValue);
				query += " AND B.CategoryID = @CategoryID";
				parameters.Add(new SqlParameter("@CategoryID", CID));
			}

			// Adding search filters to the query
			if (!string.IsNullOrWhiteSpace(STitleText.Text)) // By the Book's Title
			{
				query += " AND B.Title LIKE @Title";
				parameters.Add(new SqlParameter("@Title", sTitle));
			}
			if (!string.IsNullOrWhiteSpace(SAuthorText.Text)) // By the Author's Namr
			{
				query += " AND B.Author LIKE @Author";
				parameters.Add(new SqlParameter("@Author", sAuthor));
			}
			if (!string.IsNullOrWhiteSpace(SISBNText.Text)) //By the Book's ISBN
			{
				query += " AND B.ISBN LIKE @ISBN";
				parameters.Add(new SqlParameter("@ISBN", sISBN));
			}

			// Connecting to the database and executing the query
			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, conn))
			{
				command.Parameters.AddRange(parameters.ToArray());
				conn.Open();

				// Reading the data from the database
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						bookData.Add(new Book()
						{
							BookID = Convert.ToInt32(reader["BookID"]),
							Title = reader["Title"].ToString(),
							Author = reader["Author"].ToString(),
							ISBN = reader["ISBN"].ToString(),
							CategoryID = Convert.ToInt32(reader["CategoryID"]),
							PublicationYear = (DateTime)reader["PublicationYear"],
							TotalCopies = Convert.ToInt32(reader["TotalCopies"]),
							AvailableCopies = Convert.ToInt32(reader["AvailableCopies"])
						});
					}
				}
			}
			return bookData;
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Form form = new Main();
			form.Show();
			this.Hide();
		}
	}
}
