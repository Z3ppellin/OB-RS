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
	public partial class frmForgotPassword : Form
	{
		public frmForgotPassword()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{										
			string newPassword;
			string userName;

			//Opening connection to database
			OleDbCommand cmd = new OleDbCommand();
			OleDbConnection myCon = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\Desktop\Olympus Hotel\OlympusBooking\OlympusBooking\App_Data\database.accdb");

			//Initialising variables
			newPassword = tbPassword.Text;
			userName = tbUserName.Text;
			if (tbPassword.Text != tbConfirmPassword.Text)
			{
				epPassword.SetError(this.tbConfirmPassword, "Passwords do not match");
			}
			else
			{
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "UPDATE [User] SET [Password] = @newPassword WHERE [Username] = @userName";

				cmd.Parameters.AddWithValue("@newPassword", newPassword);
				cmd.Parameters.AddWithValue("@userName", userName);

				cmd.Connection = myCon;
				myCon.Open();
				cmd.ExecuteNonQuery();
				System.Windows.Forms.MessageBox.Show("Password has been reset!", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				myCon.Close();
								
				Application.Restart();
				
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
