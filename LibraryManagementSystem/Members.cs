using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
	public class Members
	{
		public int MembersID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime JoinDate { get; set; }
		public Members() { }
		public Members(int membersID, string firstName, string lastName, string email, string phoneNumber, DateTime joinDate)
		{
			MembersID = membersID;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			PhoneNumber = phoneNumber;
			JoinDate = joinDate;
		}
	}
}
