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
using System.IO;

namespace OlympusBooking
{
    public partial class frmCheckIn : Form
    {
        //Initialises 2 DateTime variables to calculate the number of days a guest will stay.
        DateTime d1;
        DateTime d2;

        //Global variables.
        int subTotalDays;
        int subTotalPeople = 0;
        int subTotal = 0;
        int roomRate = 0;
        int c;
        static int first = 0, second = 0;

        public frmCheckIn()
        {
            InitializeComponent();
            dtpCheckOutDate.MinDate = DateTime.Now.AddDays(1);
            d1 = DateTime.Now;
            txtCheckInDate.Text = d1.ToString();
            d2 = dtpCheckOutDate.Value;
            int iNumDays = (Convert.ToInt32((d2 - d1).TotalDays));
            txtNoDays.Text = iNumDays.ToString();
        }

        //When the Check-In button is clicked.
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            //Declaring variables used in the check form.
            string guestName = txtGuestName.Text;
            string roomNum = txtRoomNumber.Text;
            string roomType = txtRoomType.Text;
            string numPeople = (numAdults.Value).ToString();
			DateTime currentDate = DateTime.Now;

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Checks whether text box fields have values entered.
            if ((epGuestName.GetError(this.txtGuestName).Length > 0) || (epRoomNo.GetError(this.txtRoomNumber).Length > 0) || (epNumPeople.GetError(this.numAdults).Length > 0))
            {
                MessageBox.Show("Please attend to any errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                //Create a new instance of the UseDatabase case.
                UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");
                useDb.ConnectToDatabase();
                string b = useDb.CheckIn(guestName, d1.ToString(), roomNum, numPeople, subTotal);

                //Informs user of success or failure of database entry.
                if (b == "success")
                {
                    MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					File.AppendAllText("..\\..\\App_Data\\LogFiles\\Check-In.txt", "Guest : " + guestName + " Has been Checked-in ,on : " + currentDate + Environment.NewLine);
				}
                else
                {
                    MessageBox.Show("Fail");
                }

                useDb.DisconnectDatabase();
            }
        }

        //Already inserts the check in date and time when the form loads.
        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.CheckIn' table. You can move, or remove it, as needed.
            this.checkInTableAdapter.Fill(this.databaseDataSet.CheckIn);
            dtpCheckOutTime.ShowUpDown = true;
        }

        //Closes the Check-In form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //When the checkout date gets changed the number of days do as well.
        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            d2 = dtpCheckOutDate.Value;
            int iNumDays = (Convert.ToInt32((d2-d1).TotalDays));
            txtNoDays.Text = iNumDays.ToString();
        }

        private void txtRoomNumber_Leave(object sender, EventArgs e)
        {
            //Checks if the room no field is empty.
            if (txtRoomNumber.Text != "")
            {
                epGuestName.Clear();

                //New instance of UseDatabase class.
                UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");

                //Connect database.
                useDb.ConnectToDatabase();

                //Execute query to autofill room data from the room number provided.
                string queryString = "SELECT RoomType, RoomRate FROM [Room] WHERE RoomNumber = '" + txtRoomNumber.Text + "'";

                //Execute query to check for matches in the database.
                OleDbDataReader dbReader = useDb.ExecuteQuery(queryString);

                //If there are rows in the result from the ExecuteQuery then the check was successful meaning there was a match.
                if (dbReader != null && dbReader.HasRows)
                {
                    //Checks for matches to the room no to get the room type and rate from the database.
                    if (dbReader.Read())
                    {
                        txtRoomType.Text = dbReader[0].ToString();
                        txtRoomRate.Text = dbReader[1].ToString();
                        roomRate = Convert.ToInt32(txtRoomRate.Text);
                        txtSubTotal.Text = "R" + txtRoomRate.Text;
                        subTotal = Convert.ToInt32(txtNoDays.Text) * roomRate;
                    }
                }
                else
                {
                    //Informs the user if the room was not found.
                    epRoomNo.SetError(this.txtRoomNumber, "Room number not found");
                }
            }
            else
            {
                //Asks the user to enter a room no.
                epRoomNo.SetError(this.txtRoomNumber, "Please enter a room number");
            }
        }

        //Changes the subtotal value to increase the price by 30% for each person more than two living in the room.
        private void numAdults_ValueChanged(object sender, EventArgs e)
        {
            if (txtRoomNumber.Text != "")
            {
                if (numAdults.Value > 2)
                {
                    if (numAdults.Value >= c)
                    {
                        roomRate = Convert.ToInt32(txtRoomRate.Text);
                        subTotalPeople = subTotalPeople + Convert.ToInt32((roomRate * 0.3));
                        subTotalDays = (Convert.ToInt32(txtRoomRate.Text) * Convert.ToInt32(txtNoDays.Text));
                        subTotal = subTotalDays + subTotalPeople;
                        txtSubTotal.Text = "R" + subTotal.ToString();
                    }
                    else if ((numAdults.Value < c) && subTotalPeople != 0)
                    {
                        roomRate = Convert.ToInt32(txtRoomRate.Text);
                        subTotalPeople = subTotalPeople - Convert.ToInt32((roomRate * 0.3));
                        subTotal = subTotalDays + subTotalPeople;
                        txtSubTotal.Text = "R" + subTotal.ToString();
                    }

                    c = Convert.ToInt32(numAdults.Value);
                }
                else if (numAdults.Value < 3)
                {
                    subTotalPeople = 0;
                    subTotal = roomRate * Convert.ToInt32(txtNoDays.Text);
                    txtSubTotal.Text = "R" + subTotal.ToString();
                }
            }
        }

        private void txtGuestName_Leave(object sender, EventArgs e)
        {
            if (txtGuestName.Text != "")
            {
                //Clears the error provider for guest name.
                epGuestName.Clear();

                //New instance of UseDatabase class.
                UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");

                //Connect database.
                useDb.ConnectToDatabase();

                //Execute query to autofill room data from the room number provided.
                string queryString = "SELECT GuestName FROM [Guest] WHERE Guestname = '" + txtGuestName.Text + "'";

                //Execute query to check for matches in the database.
                OleDbDataReader dbReader = useDb.ExecuteQuery(queryString);

                //If there are rows in the result from the ExecuteQuery then the check was successful meaning there was a match.
                if (dbReader != null && dbReader.HasRows)
                {
                    epGuestName.Clear();
                }
                else
                {
                    epGuestName.SetError(this.txtGuestName, "Guest not found");
                }
            }
            else
            {
                epGuestName.SetError(this.txtGuestName, "Please enter a guest name");
            }
        }

        //Updates the cost per amount of days staying in.
        private void txtNoDays_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtRoomRate.Text, out second) && Int32.TryParse(txtNoDays.Text, out first))
            {
                subTotalDays = (first * second);
                subTotal = subTotalPeople + subTotalDays;
                txtSubTotal.Text = "R" + subTotal.ToString();
            }
        }
    }
}
