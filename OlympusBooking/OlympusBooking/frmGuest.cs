////////////////////////////////////////////////////////////////////////////////////////////////////
// Filename         :                                                                             //
// Author           :                                                                             //
// Created          :                                                                             //
// Created using    :                                                                             //
// Usable on        :                                                                             //
// Discription      :                                                                             //
////////////////////////////////////////////////////////////////////////////////////////////////////

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
using System.IO;

namespace OlympusBooking
{
    public partial class frmGuest : Form
    {
        public frmGuest()
        {
            InitializeComponent();
            cbGender.SelectedIndex = 0; //Sets the default of the combobox to the first index.
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
			DateTime currentDate = DateTime.Now;
            //Validates if all the fields are entered and that there are no error messages before saving the data to the database.
            if ((txtName.Text == "") || (txtSurname.Text == "") || (txtAddress.Text == "") || (txtNum.Text == "") || (txtEmail.Text == ""))
            {
                //Message box to inform the user of errors.
                MessageBox.Show("Please ensure all fields have values entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {    
                if ((epContact.GetError(this.txtNum).Length > 0) || (epEmail.GetError(this.txtEmail).Length > 0))
                {
                    //Message box to inform the user of errors.
                    MessageBox.Show("Please attend to any error messages", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Calls methods form the UseDatabase case to add a new quest.
                    UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");
                    useDb.ConnectToDatabase();
                    string b = useDb.addGuest(sName, sSurname, sAddress, sNum, sGender, sEmail, sStatus);
                    useDb.DisconnectDatabase();

                    //Informs the user if the database was updated
                    if (b == "success")
                    {
                        MessageBox.Show("A guest has been successfully added", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
						File.AppendAllText("..\\..\\App_Data\\LogFiles\\Guest.txt", "Guest : " + sName + " Has been added :" + currentDate + Environment.NewLine);///////////////////////////////////////////////////////////////////////////////////////////
					}
                    else
                    {
                        MessageBox.Show("There was a problem with inserting into the database", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    this.Close();
                }
            }           
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
                    int temp = Convert.ToInt32(txtNum.Text);
                    epContact.Clear();
                }
                catch (Exception)
                {
                    epContact.SetError(this.txtNum, "Please enter a valid number");
                    return;
                }
            }
            else
            {
                epContact.SetError(this.txtNum, "Please enter a valid number");
            }         
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                epEmail.Clear();   
            }
            else
            {
                epEmail.SetError(this.txtEmail, "Please enter a valid email address");
                return;
            }
        }
        #endregion

        private void frmGuest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Guest' table. You can move, or remove it, as needed.
            this.guestTableAdapter.Fill(this.databaseDataSet.Guest);
        }
    }
}
