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
        private void ToolStripGuest_Click(object sender, EventArgs e)
        {
            frmGuest fGuest = new frmGuest();
            fGuest.ShowDialog();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripButton13_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
