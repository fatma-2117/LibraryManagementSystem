using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
	public class Borrowings
	{
		public int BorrowID {  get; set; }
		public int BookID {  get; set; }
		public string BookName { get; set; }
		public  int MemberID {  get; set; }
		public string MemberName { get; set; }
		public DateTime BorrowDate {  get; set; }
		public DateTime DueDate { get; set; }
		public DateTime? ReturnDate {  get; set; }
		public Borrowings() { }
		public Borrowings(int borrowID, int bookID, int memberID, DateTime borrowDate, DateTime dueDate, DateTime returnDate)
		{
			BorrowID = borrowID;
			BookID = bookID;
			MemberID = memberID;
			BorrowDate = borrowDate;
			DueDate = dueDate;
			ReturnDate = returnDate;
		}
		public DateTime SetCurrentDate()
		{
			BorrowDate = DateTime.Now;
			return BorrowDate;
		}
		public DateTime generateDueDate()
		{
			DueDate = DateTime.Now.AddDays(14);
			return DueDate;
		}

	}
}
