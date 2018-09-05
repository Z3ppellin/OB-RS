using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //Initialising variables for guest form
            fName = tbfName.Text;
            lName = tblName.Text;
            mName = tbmname.Text;
            add = tbAdd.Text;
            contNum = tbNum.Text;
            gender = cbGender.Text;
            email = tbEmail.Text;
                
        }

        //Closes the guest form and reverts back to main
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();                        
        }
    }
}
