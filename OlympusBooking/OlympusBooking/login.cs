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
using System.Data.SqlClient;

namespace OlympusBooking
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {                     
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = database.accdb");
           
            OleDbCommand cmd = new OleDbCommand();
            int i =0;
            try
            {
                if ((Username.Text == string.Empty) || tbPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please enter your username and password");
                }

                cmd = new OleDbCommand("SELECT count(*) FROM tblUser WHERE username = '" + Username.Text + "' AND password = '" + tbPassword.Text + "'", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    i = (int)cmd.ExecuteScalar();

                }
                conn.Close();
                if (i > 0)
                {
                    this.Close();
                    MessageBox.Show("Yass");
                }
                else
                {
                    MessageBox.Show("Invalid login!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
                
        }

    }
}
