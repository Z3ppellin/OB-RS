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

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            //Declaring variables used in the check form.
            string guestName;
            string roomNum;
            string roomType;
            string roomRate;
            string checkInDate;
            string numOfDays;
            int inumAdults;
            int inumChildren;
            string subTotal;
            string totalBalance;

            //Initialising variables to given values.
            guestName = txtGuestName.Text;
            roomNum = txtRoomNumber.Text;
            roomType = txtRoomType.Text;
            roomRate = txtRoomRate.Text;
            checkInDate = DateTime.Now.ToString();
            numOfDays = txtNoDays.Text;
            inumAdults = Convert.ToInt32(numAdults.Value);
            subTotal = txtSubTotal.Text.ToString();
            totalBalance = txtTotal.Text.ToString();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //Create a new instance of the UseDatabase case.
            UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");
            useDb.ConnectToDatabase();
            string b = useDb.CheckIn(guestName);
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
            d1 = DateTime.Now;
            txtCheckInDate.Text = d1.ToString();
            dtpCheckOutTime.ShowUpDown = true;
        }

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
    }
}
