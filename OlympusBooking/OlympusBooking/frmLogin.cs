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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Variables.
            string sName = txtUsername.Text;
            string sPassword = txtPassword.Text;

            //New instance of UseDatabase class.
            UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");

            //Connect database.
            useDb.ConnectToDatabase();

            //Generates a query for the database containing the username and password
            string queryString = "SELECT * FROM [Users] WHERE Username = '";
            queryString += sName.ToLower() + "'AND Password = '";   //changes the username to lowercase since it is not case sensitive to avoid errors.
            queryString += sPassword + "';";

            //Execute query to check for matches in the database.
            OleDbDataReader dbReader = useDb.ExecuteQuery(queryString);

            //If there are rows in the result from the ExecuteQuery then the check was successful meaning there was a match.
            if (dbReader != null && dbReader.HasRows)
            {
                //Informs the user that the login was successfull with a warming message.
                this.Hide();
                MessageBox.Show("Welcome " + sName , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain fM = new frmMain(txtUsername.Text);
                fM.ShowDialog();
            }
            else
            {
                //Informs the user that either the username or password is incorrect.
                MessageBox.Show("Incorrect username or password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Well too bad", "Oops", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
