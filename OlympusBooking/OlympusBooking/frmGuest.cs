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
using System.Text.RegularExpressions;

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
            //Declaring variables for use in the guest form.
            string sName = txtName.Text;
            string sSurname = txtSurname.Text;
            string sAddress = txtAddress.Text;
            string sNum = txtNum.Text;
            string sGender = cbGender.Text;
            string sEmail = txtEmail.Text;
            string sStatus = "";

            //Calls methods form the UseDatabase case to add a new quest.
            UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");
            useDb.ConnectToDatabase();
            useDb.addGuest(sName,sSurname,sAddress,sNum,sGender,sEmail,sStatus);
            MessageBox.Show("A guest has been successfully added", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            useDb.DisconnectDatabase();

            this.Close();
        }

        //Closes the guest form and reverts back to main form.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Validation
        //Validates the contact number entered so that it is only numbers and 10 characters in length.
        private void txtNum_Leave(object sender, EventArgs e)
        {
            if (txtNum.TextLength == 10)
            {
                try
                {
                    epContactNo.Clear();
                    int temp = Convert.ToInt32(txtNum.Text);
                    btnSave.Enabled = true;
                }
                catch (Exception h)
                {
                    epContactNo.SetError(this.txtNum, "Please enter a valid number");
                    btnSave.Enabled = false;
                }
            }
            else
            {
                epContactNo.SetError(this.txtNum, "Please enter a valid number");
                btnSave.Enabled = false;
            }
            
        }
        #endregion
    }
}
