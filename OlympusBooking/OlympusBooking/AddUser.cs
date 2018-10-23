using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OlympusBooking
{
	public partial class frmAddUser : Form
	{
		public frmAddUser()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string userName;
			string Password;

			userName = tbUserName.Text;
			Password = tbPassword.Text;

            OleDbCommand cmd = new OleDbCommand();
            UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");
            string b = useDb.addUser(userName, Password);

            if (b == "success")
            {
                MessageBox.Show("A User has been successfully added", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to insert new user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
		}

	}
}
