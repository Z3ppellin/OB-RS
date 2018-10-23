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
    public partial class frmCheckIn : Form
    {
        //Initialises 2 DateTime variables to calculate the number of days a guest will stay.
        DateTime d1;
        DateTime d2;

        public frmCheckIn()
        {
            InitializeComponent();         
        }

        //When the Check-In button is clicked.
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            //Declaring variables used in the check form.
            string guestName;
            string roomNum;
            string roomType;
            string roomRate;
            string checkInDate;
            string numOfDays;
            string numPeople;
            string subTotal;

            //Initialising variables to given values.
            guestName = txtGuestName.Text;
            roomNum = txtRoomNumber.Text;
            roomType = txtRoomType.Text;
            roomRate = txtRoomRate.Text;
            checkInDate = DateTime.Now.ToString();
            numOfDays = txtNoDays.Text;
            numPeople = (numAdults.Value).ToString();
            subTotal = txtSubTotal.Text.ToString();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //Create a new instance of the UseDatabase case.
            UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");
            useDb.ConnectToDatabase();
            string b = useDb.CheckIn(guestName, roomNum, numPeople);
            //Informs user of success or failure of database entry.
            if (b == "success")
            {
                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fail");
            }
            
            useDb.DisconnectDatabase();

        }

        //Already inserts the check in date and time when the form loads.
        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.CheckIn' table. You can move, or remove it, as needed.
            this.checkInTableAdapter.Fill(this.databaseDataSet.CheckIn);
            d1 = DateTime.Now;
            txtCheckInDate.Text = d1.ToString();
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
                //Informs the user that the login was successfull with a warming message.
                if (dbReader.Read())
                {
                    txtRoomType.Text = dbReader[0].ToString();
                    txtRoomRate.Text = dbReader[1].ToString();
                }
            }
            else
            {
                MessageBox.Show("Room no does not exist");
            }
        }

        private void numAdults_ValueChanged(object sender, EventArgs e)
        {
            txtSubTotal.Text = "R " + (Convert.ToInt32(txtRoomRate.Text) * numAdults.Value);
        }
    }
}
