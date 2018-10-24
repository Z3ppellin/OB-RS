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

            if (tbUserName.Text == "" || tbPassword.Text == "" || tbConfirmPassword.Text == "")
            {
                MessageBox.Show("Please ensure all fields are entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Opening connection to database
                OleDbCommand cmd = new OleDbCommand();
                OleDbConnection myCon = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ..\\..\\App_Data\\database.accdb");

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
                    cmd.CommandText = "UPDATE [Users] SET [Password] = @newPassword WHERE [Username] = @userName";

                    cmd.Parameters.AddWithValue("@newPassword", newPassword);
                    cmd.Parameters.AddWithValue("@userName", userName);

                    cmd.Connection = myCon;
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password has been reset!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    myCon.Close();

                    //Restarts application after changing password.
                    Application.Restart();
                }
            }
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
