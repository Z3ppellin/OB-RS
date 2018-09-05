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
    public partial class frmGuest : Form
    {
        public frmGuest()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Declaring variables for use of guest form
            string sName = txtName.Text;
            string sSurname = txtSurname.Text;
            string sAddress = txtAddress.Text;
            string sNum = txtNum.Text;
            string sGender = cbGender.Text;
            string sEmail = tbEmail.Text;
            string sStatus = "Checked-In";

            UseDatabase useDb = new UseDatabase(Application.StartupPath + "\\App_Data\\database.accdb");
            useDb.ConnectToDatabase();
            useDb.addGuest(sName,sSurname,sAddress,sNum,sGender,sEmail,sStatus);
            useDb.DisconnectDatabase();
        }

        //Closes the guest form and reverts back to main
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
