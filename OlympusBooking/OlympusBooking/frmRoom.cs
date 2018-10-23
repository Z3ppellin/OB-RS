////////////////////////////////////////////////////////////////////////////////////////////////////
// Filename         :                                                                             //
// Author           :                                                                             //
// Created          :                                                                             //
// Created using    :                                                                             //
// Usable on        :                                                                             //
// Discription      :                                                                             //
////////////////////////////////////////////////////////////////////////////////////////////////////

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

            //Initialising variables used in new room form
            roomNum = txtRoomNumber.Text;
            roomType = txtRoomType.Text;
            roomRate = txtRoomRate.Text.ToString();

            if ((txtRoomNumber.Text == "") || (txtRoomType.Text == "") || (txtRoomRate.Text == ""))
            {
                //Message box to inform the user of errors.
                MessageBox.Show("Please ensure all fields have values entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //creates new instance of the Usedatabase case.
                UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");
                useDb.ConnectToDatabase();
                //Runs the method to add a room and returns a string as result.
                string b = useDb.addRoom(roomNum, roomType, roomRate);
                useDb.DisconnectDatabase();

                //Informs the user if the room was added or if there was an error.
                if (b == "success")
                {
                    MessageBox.Show("A guest has been successfully added", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There was a problem with inserting into the database", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
        }

        //Closing room form when canceled
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.databaseDataSet.Room);

        }
    }
}
