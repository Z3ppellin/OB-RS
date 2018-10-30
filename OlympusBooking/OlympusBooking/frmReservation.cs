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

namespace OlympusBooking
{
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            //declaring variables used in the reservation form
            string guestName;
            string roomNum;
            string rType;
            string rRate;
            string checkInDate;
            string checkOutDate;
            string noDays;
            string noOfPeople;            
            string subTotal;
			DateTime currentDate = DateTime.Now;

            //initialising the variable2s used in the reservation form
            guestName = tbGuestName.Text;
            roomNum = tbRoomNum.Text.ToString();
            rType = tbRoomType.Text;
            rRate = tbRoomRate.Text.ToString();
            checkInDate = dtpCheckIn.Text;
            checkOutDate = dtpCheckOut.Text;
            noDays = tbNoDays.Text.ToString();
            noOfPeople = cbAdults.Text.ToString();            
            subTotal = tbSubTotal.Text.ToString();

			////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			//Check whether text box fields have values entered.

			if ((epGuestName.GetError(this.tbGuestName).Length > 0) || ((epRoomNum.GetError(this.tbRoomNum).Length > 0)))
			{
				MessageBox.Show("Please attend to any errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//Create a new instance of the UseDatabase case.
				UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");
				useDb.ConnectToDatabase();
				string b = useDb.Reservation(guestName, roomNum, checkInDate,noOfPeople,subTotal);

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

        private void frmReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.databaseDataSet.Reservation);

        }
    }
}
