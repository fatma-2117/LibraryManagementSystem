using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
	public class Book
	{
		public int BookID {  get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public string ISBN { get; set; }
		public DateTime PublicationYear {  get; set; }
		public int CategoryID {  get; set; }
		public int TotalCopies {  get; set; }
		public int AvailableCopies { get; set; }
		public Book() { }
		public Book(int bookID, string title, string author, string iSBN, DateTime publicationYear, int categoryID, int totalCopies, int availableCopies)
		{
			BookID = bookID;
			Title = title;
			Author = author;
			ISBN = iSBN;
			PublicationYear = publicationYear;
			CategoryID = categoryID;
			TotalCopies = totalCopies;
			AvailableCopies = availableCopies;
		}
	}
}
