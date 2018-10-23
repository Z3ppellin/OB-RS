////////////////////////////////////////////////////////////////////////////////////////////////////
// Filename         :                                                                             //
// Author           :                                                                             //
// Created          :                                                                             //
// Created using    :                                                                             //
// Usable on        :                                                                             //
// Discription      :                                                                             //
////////////////////////////////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Linq;
using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;

namespace OlympusBooking
{
    public partial class frmMain : Form
    {
        public frmMain(string sUsername)
        {
            InitializeComponent();
            lblLoggedIn.Text = "Logged in: " + sUsername;
            tCurrentTime.Start();

            //If the admin is logged in the New User toolstrip menu item becomes available to add new users to the system.
            if (sUsername.ToLower() == "admin")
            {
                newUserToolStripMenuItem.Visible = true;
                toolStripSeparator3.Visible = true;
            }
        }

        //When the Exit toolbar is clicked the application will close.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //When Guest is clicked it opens the Guest form.
        private void toolbarGuest_Click(object sender, EventArgs e)
        {
            frmGuest fGuest = new frmGuest();
            fGuest.ShowDialog();
            
        }

        //Closes application.
        private void toolbarExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Opens the Room form.
        private void toolbarRoom_Click(object sender, EventArgs e)
        {
            frmRoom fRoom = new frmRoom();
            fRoom.ShowDialog();
        }

        //Opens the check-in form.
        private void toolbarCheckIn_Click(object sender, EventArgs e)
        {
            frmCheckIn fCheckIn = new frmCheckIn();
            fCheckIn.ShowDialog();
        }

        //Opens the check-out form
        private void toolbarCheckOut_Click(object sender, EventArgs e)
        {
            frmCheckOut fCheckOut = new frmCheckOut();
            fCheckOut.ShowDialog();
        }

        //Opens the Reservation form
        private void toolbarReserve_Click(object sender, EventArgs e)
        {
            frmReservation fRes = new frmReservation();
            fRes.ShowDialog();
        }

        //Logs the user out. (Restarts application)
        private void toolbarLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Opens the guest form.
        private void newGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGuest frmGuest = new frmGuest();
            frmGuest.ShowDialog();
        }

        //Timer to display current date and time as it goes.
        private void tCurrentTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblDateTime.Text = "Date and Time: " + dateTime.ToString();
        }

        //Opens the Reservation form.
        private void newReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservation frmReservation = new frmReservation();
            frmReservation.ShowDialog();
        }

        //Opens the Check-In form
        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckIn frmCheckIn = new frmCheckIn();
            frmCheckIn.ShowDialog();
        }

        //Opens the Check-Out form.
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckOut frmCheckOut = new frmCheckOut();
            frmCheckOut.ShowDialog();
        }

        //Logs the user out. (Restarts application)
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
        }
    }
}
