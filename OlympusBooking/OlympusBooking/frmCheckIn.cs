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
        public frmCheckIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            //Declaring variables used in the check form
            string guestName;
            string roomNum;
            string roomType;
            string roomRate;
            string checkInDate;
            string numOfDays;
            string numAdults;
            string numChildren;
            string subTotal;
            string totalBalance;

            //Initialising variables to given values
            guestName = tbGuestName.Text;
            roomNum = tbRoomNumber.Text;
            roomType = tbRoomType.Text;
            roomRate = tbRoomRate.Text;
            checkInDate = DateTime.Now.ToString();

            numOfDays = tbNoOfDays.Text;
            numAdults = cbAdults.SelectedValue.ToString();
            numChildren = cbChildren.SelectedValue.ToString();
            subTotal = tbTotal.Text.ToString();
            totalBalance = tbBalance.Text.ToString();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            UseDatabase useDb = new UseDatabase(Application.StartupPath + "\\App_Data\\database.accdb");
            useDb.ConnectToDatabase();

            OleDbCommand cmd = new OleDbCommand("INSERT into Guest(guestName) VALUES(@guestName) ");
            cmd.Parameters.Add("@guestName", OleDbType.VarChar).Value = guestName;


            useDb.DisconnectDatabase();

        }


        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            tbCheckInDate.Text = DateTime.Now.ToString();
        }
    }
}
