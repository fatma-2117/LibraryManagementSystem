using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
	public class Categories
	{
		public int CategoryID {  get; set; }
		public string CategoryName { get; set; }
		public Categories() { }
		public Categories(int categoryID, string categoryName)
		{
			CategoryID = categoryID;
			CategoryName = categoryName;
		}
	}
}
