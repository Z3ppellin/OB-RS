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
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            //declaring variables used in the reservation form
            string gName;
            string rNum;
            string rType;
            string rRate;
            string checkInDate;
            string checkOutDate;
            string noDays;
            string adults;
            string children;
            string subTotal;
            string total;

            //initialising the variable2s used in the reservation form
            gName = tbGuestName.Text;
            rNum = tbRoomNum.Text.ToString();
            rType = tbRoomType.Text;
            rRate = tbRoomRate.Text.ToString();
            checkInDate = dtpCheckIn.Text;
            checkOutDate = dtpCheckOut.Text;
            noDays = tbNoDays.Text.ToString();
            adults = cbAdults.Text.ToString();
            children = cbChildren.Text.ToString();
            subTotal = tbSubTotal.Text.ToString();
            total = tbTotal.Text.ToString();
              
        }
    }
}
