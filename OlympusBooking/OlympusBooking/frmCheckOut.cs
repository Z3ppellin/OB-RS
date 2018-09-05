﻿using System;
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
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //Declaring variables used in check out guest form
            string guestName;
            string roomNum;
            string roomType;
            string roomRate;
            string checkIn;
            string checkOut;
            string days;
            string children;
            string adults;
            string subTotal;
            string totBalance;

            //Initialising variables in check out guest form
            guestName = tbGuestName.Text;
            roomNum = tbRoomNumber.Text.ToString();
            roomType = tbRoomType.Text;
            roomRate = tbRoomRate.Text.ToString();
            checkIn = tbCheckIn.Text;
            checkOut = tbCheckOut.Text;
            days = tbDays.Text.ToString();
            children = tbChildren.Text.ToString();
            adults = tbAdults.Text.ToString();
            subTotal = tbTotal.Text.ToString();
            totBalance = tbBalance.Text.ToString();

            //Displaying a message to confirm that guest is checked out
            MessageBox.Show("Guest/s checked out successfuly!");
            this.Close();
        }
    }
}
