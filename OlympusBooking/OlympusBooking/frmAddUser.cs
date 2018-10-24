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
            //Checks whether text box fields have values entered.
            if (tbUserName.Text != "" || tbPassword.Text != "" || tbConfirmPassword.Text != "")
            {
                //Checks if there are no error messages before trying to add the user to the database.
                if (epPasswordCheck.GetError(this.tbConfirmPassword).Length > 0)
                {
                    //informs the user there are errors
                    MessageBox.Show("Please attend to any error messages first", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //initialise variables.
                    string userName = tbUserName.Text;
                    string Password = tbPassword.Text;

                    UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");
                    string b = useDb.addUser(userName, Password);

                    //Informs the user if user was added successfully to the database or not.
                    if (b == "success")
                    {
                        MessageBox.Show("User has been added successfully", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please ensure all fields are entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
		}

        private void tbConfirmPassword_Leave(object sender, EventArgs e)
        {
            //shows an error provider message if the two password fields do not match.
            if (tbConfirmPassword.Text == tbPassword.Text)
            {
                epPasswordCheck.Clear();
            }
            else
            {
                epPasswordCheck.SetError(this.tbConfirmPassword, "Passwords do not match");
            }
        }
    }
}
