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
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //When Guest is clicked it opens the Guest form.
        private void toolbarGuest_Click(object sender, EventArgs e)
        {
            frmGuest fGuest = new frmGuest();
            fGuest.ShowDialog();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = "Date and Time: " + DateTime.Now.ToString();
            lblLoggedIn.Text = "Logged in: ";
        }

        private void toolbarExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void toolbarRoom_Click(object sender, EventArgs e)
        {
            frmRoom fRoom = new frmRoom();
            fRoom.ShowDialog();
        }

        private void toolbarCheckIn_Click(object sender, EventArgs e)
        {
            frmCheckIn fCheckIn = new frmCheckIn();
            fCheckIn.ShowDialog();
        }

        private void toolbarCheckOut_Click(object sender, EventArgs e)
        {
            frmCheckOut fCheckOut = new frmCheckOut();
            fCheckOut.ShowDialog();
        }

        private void toolbarReserve_Click(object sender, EventArgs e)
        {
            frmReservation fRes = new frmReservation();
            fRes.ShowDialog();
        }

        private void toolbarLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void newGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGuest frmGuest = new frmGuest();
            frmGuest.ShowDialog();
        }
    }
}
