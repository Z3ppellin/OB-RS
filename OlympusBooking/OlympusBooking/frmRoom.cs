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
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Declaring variables used in the new room form
            string roomNum;
            string roomType;
            string roomRate;
            string numPeople;

            //Initialising variables used in new room form

            roomNum = tbRoomNumber.Text;
            roomType = tbRoomType.Text;
            roomRate = tbRoomRate.Text.ToString();
            numPeople = cbNumPeople.Text.ToString();
                                   
            
        }

        //Closing room form when canceled
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
