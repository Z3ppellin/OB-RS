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
	public partial class frmAdminConfirm : Form
	{
		public frmAdminConfirm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			String sPassword = tbAdminPassword.Text;
						
			//New instance of UseDatabase class.
			UseDatabase useDb = new UseDatabase(Application.StartupPath + "\\App_Data\\database.accdb");

			//Connect database.
			useDb.ConnectToDatabase();

			string queryString = "SELECT * FROM [Users] WHERE Username = 'Admin' AND Password = '";
			queryString += sPassword + "';";

			//Execute query to check for matches.
			OleDbDataReader dbReader = useDb.ExecuteQuery(queryString);

			//If there are rows in the result from the ExecuteQuery then the check was successful.
			if (dbReader != null && dbReader.HasRows)
			{
				this.Hide();
				MessageBox.Show("Success!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				frmForgotPassword FP = new frmForgotPassword();
				FP.ShowDialog();
			}
			else
			{
				MessageBox.Show("Incorrect password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}		

		private void frmAdminConfirm_close(object sender, EventArgs e)
		{
			if (tbAdminPassword == null)
			{
				MessageBox.Show("Please enter Admin password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tbAdminPassword.Focus();
			}			
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
