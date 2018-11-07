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
    public partial class frmRemoveUser : Form
    {
        public frmRemoveUser()
        {
            InitializeComponent();
        }

        private void frmRemoveUser_Load(object sender, EventArgs e)
        {
            //Refreshes the data grid view anytime the form loads.
            this.usersTableAdapter.Fill(this.databaseDataSet.Users);
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ..\\..\\App_Data\\database.accdb; Persist Security Info=False; ");
            string sql = "SELECT * FROM Users";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds,"Users");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Users";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Creates a connection to the database.
            OleDbConnection oleConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ..\\..\\App_Data\\database.accdb; Persist Security Info=False; ");
            OleDbCommand delcmd = new OleDbCommand();
            oleConn.Open();

            //Checks which row is selected to delete.
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow delrow = dataGridView1.Rows[i];
                if (delrow.Selected == true)
                {
                    try
                    {
                        //Gets the cell value.
                        int ID = Convert.ToInt32(dataGridView1.Rows[i].Cells["ID"].Value);
                        //Removes the row from the grid view and the database.
                        dataGridView1.Rows.RemoveAt(i);
                        delcmd.CommandText = "DELETE FROM Users WHERE ID ="  + ID + "";
                        delcmd.Connection = oleConn;
                        delcmd.ExecuteNonQuery();
                        MessageBox.Show("User removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch (Exception ex)
                    {
                        //Message box passing the error.
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            oleConn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
