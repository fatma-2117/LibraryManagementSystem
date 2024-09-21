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
	public partial class BookManagement : Form
	{
		string connectionString = "Server=.;Database=LibraryManagementSystem;Trusted_Connection=True;TrustServerCertificate=True";
		BindingSource binding;
		public event Action DataSet;

		public BookManagement(Book book) : this()
		{
			binding.DataSource = book;
		}

		public BookManagement()
		{
			InitializeComponent();
			binding = new BindingSource();
			Book book = new Book();
			binding.DataSource = book;

			IdText.DataBindings.Add("Text",binding,nameof(book.BookID),true,DataSourceUpdateMode.Never);
			TitelText.DataBindings.Add("Text", binding, "Title");
			AuthorText.DataBindings.Add("Text", binding, "Author");
			ISBNText.DataBindings.Add("Text", binding, "ISBN");
			PYearText.DataBindings.Add("Text", binding, "PublicationYear");
			TCopyText.DataBindings.Add("Text", binding, "TotalCopies");
			ACopyText.DataBindings.Add("Text", binding, "AvailableCopies");

			LoadCategory();

			CategoryList.DataBindings.Add("SelectedValue", binding, nameof(book.CategoryID));
		}

		// Save button click event handler
		private void btnSave_Click(object sender, EventArgs e)
		{
			// Check if the form is filled out properly
			if (IsValidForm()) 
			{
				Book book = binding.Current as Book;

				if (book.BookID == 0)// Insert a new book record if it's a new book
				{
					Insert_Book(book);
				}

				else// Update the existing book record if it's already in the database
				{
					Update_Book(book);
				}
				DataSet?.Invoke();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Please complete the form!", "Form Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private bool IsValidForm()
		{
			return !string.IsNullOrWhiteSpace(TitelText.Text) &&
					!string.IsNullOrWhiteSpace(AuthorText.Text) &&
					!string.IsNullOrWhiteSpace(ISBNText.Text) &&
					CategoryList.SelectedIndex != -1 &&
					PYearText.Text != "1/1/0001 12:00:00 AM" &&
					TCopyText.Text != "0";
		}

		// Loads categories into the CategoryList combo box
		public void LoadCategory()
		{
			string query = "Select * From Categories";
			List<Categories> categories = new List<Categories>();
			using(SqlConnection connection = new SqlConnection(connectionString))
			using(SqlCommand command = new SqlCommand(query,connection)) 
			{
				connection.Open();
				using(SqlDataReader reader = command.ExecuteReader())
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
			// Loads categories into the CategoryList combo box
			CategoryList.DataSource = categories;
			CategoryList.DisplayMember = "CategoryName";
			CategoryList.ValueMember = "CategoryID";
		}

		// Inserts a new book record into the database
		public void Insert_Book(Book book)
		{
			string query = "INSERT INTO BOOK(Title, Author, ISBN, PublicationYear, CategoryID, TotalCopies, AvailableCopies)" +
						   "Values(@Title, @Author, @ISBN, @PublicationYear, @CategoryID, @TotalCopies, @AvailableCopies);" +
						   "Select SCOPE_IDENTITY()";
			using(SqlConnection connection = new SqlConnection(connectionString))
			{
				using(SqlCommand command = new SqlCommand(query, connection))
				{
					// Adding parameters to the SQL command
					command.Parameters.AddWithValue("@Title", book.Title);
					command.Parameters.AddWithValue("@Author", book.Author);
					command.Parameters.AddWithValue("@ISBN", book.ISBN);
					command.Parameters.AddWithValue("@PublicationYear", book.PublicationYear);
					command.Parameters.AddWithValue("@CategoryID", book.CategoryID);
					command.Parameters.AddWithValue("@TotalCopies", book.TotalCopies);
					command.Parameters.AddWithValue("@AvailableCopies", book.AvailableCopies);

					connection.Open();

					// Execute the query and retrieve the new book ID
					int id = Convert.ToInt32(command.ExecuteScalar());
					book.BookID = id;

					MessageBox.Show("The book has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					binding.ResetBindings(false);
					IdText.Refresh();
				}

			}
		}

		// Updates an existing book record in the database
		public void Update_Book(Book book)
		{
			string query = "UPDATE BOOK SET Title = @Title, Author = @Author, ISBN = @ISBN, PublicationYear = @PublicationYear, " +
						   "CategoryID = @CategoryID, TotalCopies = @TotalCopies, AvailableCopies = @AvailableCopies Where BookID = @BookID";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					// Adding parameters to the SQL command
					command.Parameters.AddWithValue("@Title", book.Title);
					command.Parameters.AddWithValue("@Author", book.Author);
					command.Parameters.AddWithValue("@ISBN", book.ISBN);
					command.Parameters.AddWithValue("@PublicationYear", book.PublicationYear);
					command.Parameters.AddWithValue("@CategoryID", book.CategoryID);
					command.Parameters.AddWithValue("@TotalCopies", book.TotalCopies);
					command.Parameters.AddWithValue("@AvailableCopies", book.AvailableCopies);
					command.Parameters.AddWithValue("@BookID", book.BookID);

					connection.Open();

					// Execute the query to update the book record
					command.ExecuteNonQuery();

					MessageBox.Show("The book has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					binding.ResetBindings(false);
					IdText.Refresh();
				}

			}
		}

		// Deletes a book record from the database
		public void Delete_Book(Book book)
		{
			string query = "Delete From Book Where BookID = @BookID";
			using(SqlConnection connection = new SqlConnection( connectionString))
			{
				using(SqlCommand command = new SqlCommand(query,connection))
				{
					// Adding the BookID parameter to the SQL command
					command.Parameters.AddWithValue("@BookID", book.BookID);

					connection.Open();
					// Execute the query to delete the book record
					command.ExecuteNonQuery();
				}
			}
		}

	}
}
