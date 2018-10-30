using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace OlympusBooking
{
    public partial class frmCheckOut : Form
    {
        //Global variables
        string roomRate;
        int subTotal;

        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {           
            //Checks if all text boxes are filled
            if (txtGuestName.Text == "" || txtRoomNo.Text == "")
            {
                MessageBox.Show("Please enter all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Checks if any error messages are active before proceeding.
                if ((epGuest.GetError(this.txtGuestName).Length > 0) || (epRoomNo.GetError(this.txtRoomNo).Length > 0))
                {
                    MessageBox.Show("Please attend to any errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Initiates variables
                    string guestName = txtGuestName.Text;
                    string checkOutDate = txtCheckOut.Text = DateTime.Now.ToString();
                    string roomNo = txtRoomNo.Text;

                    //Create a new instance of the UseDatabase case.
                    UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");
                    useDb.ConnectToDatabase();
                    string b = useDb.CheckOut(guestName, roomNo, checkOutDate);

                    //Informs user of success or failure of database entry.
                    if (b == "success")
                    {
                        MessageBox.Show("User has been checked out successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.AppendAllText("..\\..\\App_Data\\LogFiles\\Check-In.txt", "Guest : " + guestName + " Has been Checked-out ,on : " + checkOutDate + Environment.NewLine);
                    }
                    else
                    {
                        MessageBox.Show("Failed to check out user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    useDb.DisconnectDatabase();
                }
            }
        }

        //Cancel buttons closes the form.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Upon leaving focus of the Room number textbox.
        private void txtRoomNo_Leave(object sender, EventArgs e)
        {
            if (txtRoomNo.Text == "")
            {
                //Informs the user to enter a value in the Room Number field.
                epRoomNo.SetError(this.txtRoomNo, "Please enter a room number");
            }
            else
            {
                epRoomNo.Clear();

                //New instance of UseDatabase class.
                UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");

                //Connect database.
                useDb.ConnectToDatabase();

                //Execute query to autofill room data from the room number provided.
                string queryString = "SELECT GuestName, CheckInDate, NoOfDays, NoOfPeople, TotalDue FROM [CheckIn] WHERE RoomNum = '" + txtRoomNo.Text + "'";

                //Execute query to check for matches in the database.
                OleDbDataReader dbReader = useDb.ExecuteQuery(queryString);

                //If there are rows in the result from the ExecuteQuery then the check was successful meaning there was a match.
                if (dbReader != null && dbReader.HasRows)
                {
                    string queryString2 = "SELECT RoomType, RoomRate FROM [Room] WHERE RoomNumber = '" + txtRoomNo.Text + "'";
                    OleDbDataReader dbReader2 = useDb.ExecuteQuery(queryString2);

                    //Checks for matches to the room no to get the rest of the info like guest name, room type, checkin date and total payment due.
                    if (dbReader.Read())
                    {
                        txtGuestName.Text = dbReader[0].ToString();
                        txtCheckIn.Text = dbReader[1].ToString(); 
                        txtNoDays.Text = dbReader[2].ToString();
                        txtNoPeople.Text = dbReader[3].ToString();
                        txtSubTotal.Text = dbReader[4].ToString();
                    }
                    else
                    {
                        epGuest.SetError(this.txtGuestName, "Guest not checked in");
                    }
                    if (dbReader2.Read())
                    {
                        txtRoomType.Text = dbReader2[0].ToString();
                        txtRoomRate.Text = dbReader2[1].ToString();
                    }
                    else
                    {
                        epRoomNo.SetError(this.txtRoomNo, "No room found for guest name provided");
                    }
                }
                else
                {
                    //Informs the user if the room was not found.
                    epRoomNo.SetError(this.txtRoomNo, "Guest not found");
                }
            }
        }
    }
}
