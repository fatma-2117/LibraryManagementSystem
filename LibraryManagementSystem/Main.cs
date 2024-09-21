using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void btnBookM_Click_1(object sender, EventArgs e)
		{
			Form BookForm = new MainBook();
			BookForm.Show();
			this.Hide();
		}

		private void btnMemberM_Click_1(object sender, EventArgs e)
		{
			Form MemberForm = new MainMembers();
			MemberForm.Show();
			this.Hide();
		}

		private void btnBorrowM_Click(object sender, EventArgs e)
		{
			Form BorrowForm = new MainBorrowing();
			BorrowForm.Show();
			this.Hide();
		}

	}
}
