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
    public partial class frmLogin : Form
    {
        //Global variables
        string sName;
        string sPassword;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Variables.
            sName = txtUsername.Text.ToLower();
            sPassword = txtPassword.Text;

            //New instance of UseDatabase class.
            UseDatabase useDb = new UseDatabase(Application.StartupPath + "\\App_Data\\database.accdb");

            //Connect database.
            useDb.ConnectToDatabase();

            string queryString = "SELECT * FROM [User] WHERE Username = '";
            queryString += sName + "'AND Password = '";
            queryString += sPassword + "';";

            //Execute query to check for matches.
            OleDbDataReader dbReader = useDb.ExecuteQuery(queryString);

            //If there are rows in the result from the ExecuteQuery then the check was successful.
            if (dbReader != null && dbReader.HasRows)
            {
                this.Hide();
                MessageBox.Show("You have successfully logged in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain fM = new frmMain();
                fM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
