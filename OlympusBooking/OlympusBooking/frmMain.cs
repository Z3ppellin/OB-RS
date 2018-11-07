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
        string userName;
        public frmMain(string sUsername)
        {
            InitializeComponent();
            //Shows which user is logged in and capatalizes the first letter for appearances.
            userName = char.ToUpper(sUsername[0]) + sUsername.Substring(1);
            lblLoggedIn.Text = "Logged in: " + userName;
            tCurrentTime.Start();

            //If the admin is logged in the New User and Remove User toolstrip menu item becomes available to add and remove users to the system. Also makes the add new room form available.
            if (sUsername.ToLower() == "admin")
            {
                newUserToolStripMenuItem.Visible = true;
                removeUserToolStripMenuItem.Visible = true;
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
            frmRoom fRoom = new frmRoom(userName);
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

        //Opens the add user form.
        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
        }

        //Opens a new reservation form.
		private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
		{			
			frmReservation RES = new frmReservation();
			RES.tcReservation.SelectedIndex = 1;
			RES.ShowDialog();
		}

        //Opens a new room form.
		private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmRoom FR = new frmRoom(userName);
			FR.tcRoom.SelectedIndex = 1;
			FR.ShowDialog();
		}

        //Opens a new check in form.
		private void checkInListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCheckIn CI = new frmCheckIn();
			CI.tbcCheckIn.SelectedIndex = 1;
			CI.ShowDialog();
		}		

        //Opens a new guest form.
		private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmGuest FG = new frmGuest();
			FG.tcGuest.SelectedIndex = 1;
			FG.ShowDialog();
		}

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveUser RU = new frmRemoveUser();
            RU.ShowDialog();
        }
    }
}
