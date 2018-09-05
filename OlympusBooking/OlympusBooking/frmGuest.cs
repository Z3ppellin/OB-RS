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
using System.Configuration;

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
            string fName;
            string lName;
            string mName;
            string add;
            string contNum;
            string gender;
            string email;
            string status;

            //Initialising variables for guest form
            fName = tbfName.Text;
            lName = tblName.Text;
            status = "S";
            add = tbAdd.Text;
            contNum = tbNum.Text;
            gender = cbGender.Text;
            email = tbEmail.Text;

            OleDbConnection con = new OleDbConnection();
            


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            UseDatabase useDb = new UseDatabase(Application.StartupPath + "\\App_Data\\database.accdb");
            useDb.ConnectToDatabase();

            useDb.addGuest(fName,lName,add,contNum,gender,email,status);

            useDb.DisconnectDatabase();

        }
              
        //Closes the guest form and reverts back to main
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();                        
        }
    }
}
