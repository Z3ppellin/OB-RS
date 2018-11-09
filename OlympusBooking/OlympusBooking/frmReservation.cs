using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace OlympusBooking
{
    public partial class frmReservation : Form
    {
		//Initialises 2 DateTime variables to calculate the number of days a guest will stay.
		DateTime d1;
		DateTime d2;

		//Global variables
		int subTotalDays;
		int subTotalPeople = 0;
		int subTotal = 0;
		int roomRate = 0;
		int c;
		static int first = 0, second = 0;

		public frmReservation()
        {
            InitializeComponent();			
			dtpCheckOut.MinDate = DateTime.Now.AddDays(1);
			d1 = DateTime.Now;			
			d2 = dtpCheckOut.Value;
			int iNumDays = (Convert.ToInt32((d2 - d1).TotalDays));
			tbNoDays.Text = iNumDays.ToString();
		}

        private void btnReserve_Click(object sender, EventArgs e)
        {
            //declaring variables used in the reservation form
            string guestName;
            string roomNum;
            string rType;            
            string checkInDate;
            string checkOutDate;
            string noDays;
            string noOfPeople;           
            
			DateTime currentDate = DateTime.Now;

            //initialising the variable2s used in the reservation form
            guestName = tbGuestName.Text;
            roomNum = tbRoomNum.Text.ToString();
            rType = tbRoomType.Text;            
            checkInDate = dtpCheckIn.Text;
            checkOutDate = dtpCheckOut.Text;
            noDays = tbNoDays.Text.ToString();
            noOfPeople = numAdults.Text.ToString();
			//subTotal = Convert.ToInt32(tbSubTotal.Text);
			subTotal = 0;

			////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			//Check whether text box fields have values entered.

			if ((epGuestName.GetError(this.tbGuestName).Length > 0) || ((epRoomNum.GetError(this.tbRoomNum).Length > 0)))
			{
				MessageBox.Show("Please attend to any errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//Create a new instance of the UseDatabase case.
				UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");
				useDb.ConnectToDatabase();
				string b = useDb.Reservation(guestName, roomNum,checkInDate,checkOutDate,noOfPeople,noDays,subTotal.ToString());

				if (b == "success")
				{
					MessageBox.Show("Reservation successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					File.AppendAllText("..\\..\\App_Data\\LogFiles\\Check-In.txt", "Guest : " + guestName + " Has made a reservation ,on : " + currentDate + Environment.NewLine);
					this.Close();
				}
				else
				{
					MessageBox.Show("Fail");
				}

				useDb.DisconnectDatabase();

			}
			
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Reservation' table. You can move, or remove it, as needed.
            //this.reservationTableAdapter.Fill(this.databaseDataSet.Reservation);
			tbGuestName.Focus();
			this.ActiveControl = tbGuestName;
            //Refreshes the data grid view anytime the form loads.
            this.reservationTableAdapter.Fill(this.databaseDataSet.Reservation);
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ..\\..\\App_Data\\database.accdb; Persist Security Info=False; ");
            string sql = "SELECT * FROM Reservation";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Reservation");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Reservation";
        }

		//Validating to ensure texboxes has values in them
		private void tbGuestName_Validating(object sender, CancelEventArgs e)
		{
			//Error provider for the Guest name
			if (tbGuestName.Text == string.Empty)
			{
				epGuestName.Clear();
				epGuestName.SetError(tbGuestName, "Please enter a Guest name");
				tbGuestName.Focus();
			}
			else
			{
				epGuestName.Clear();
				epGuestName.SetError(tbGuestName, "");
			}
		}

		//Error provider for the room number
		private void tbRoomNum_Validating(object sender, CancelEventArgs e)
		{
			if (tbRoomNum.Text == string.Empty)
			{
				epRoomNum.SetError(tbRoomNum, "Please enter a room number");
				tbRoomNum.Focus();
			}
			else
			{
				epRoomNum.Clear();
				epRoomNum.SetError(tbRoomNum, "");
			}
		}

		//Error provider for the number of people
		private void cbAdults_Validating(object sender, CancelEventArgs e)
		{
			if (numAdults.Text == string.Empty || numAdults.Text == "0")
			{
				epNoOfPeople.Clear();
				epNoOfPeople.SetError(numAdults, "Please provide the number of people");
				numAdults.Focus();
			}
			else
			{
				epNoOfPeople.Clear();
				epNoOfPeople.SetError(numAdults, "");
			}
		}

		//Closes the form when button cancel is clicked
		private void btnCancel_Click(object sender, EventArgs e)
		{
			epGuestName.Clear();
			epNoOfPeople.Clear();
			epRoomNum.Clear();
			this.Close();
		}

		//Calculating the number of days
		private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
		{
			d2 = dtpCheckOut.Value;
			int iNumDays = (Convert.ToInt32((d2 - d1).TotalDays));
			tbNoDays.Text = iNumDays.ToString();
		}

		private void numAdults_ValueChanged(object sender, EventArgs e)
		{			
			if (numAdults.Value > 2)
			{				
				if(numAdults.Value >= c)

					{
					roomRate = Convert.ToInt32(tbRoomRate.Text);
					subTotalPeople = subTotalPeople + Convert.ToInt32((roomRate * 0.3));
					subTotalDays = (Convert.ToInt32(tbRoomRate.Text) * Convert.ToInt32(tbNoDays.Text));
					subTotal = subTotalDays + subTotalPeople;
					tbSubTotal.Text = "R" + subTotal.ToString();
				}
                else if ((numAdults.Value < c) && subTotalPeople != 0)
				{
					roomRate = Convert.ToInt32(tbRoomRate.Text);
					subTotalPeople = subTotalPeople - Convert.ToInt32((roomRate * 0.3));
					subTotal = subTotalDays + subTotalPeople;
					tbSubTotal.Text = "R" + subTotal.ToString();
				}

				c = Convert.ToInt32(numAdults.Value);
			}
			else if (numAdults.Value < 3)
			{
				subTotalPeople = 0;
				subTotal = roomRate * Convert.ToInt32(tbNoDays.Text);
				tbSubTotal.Text = "R" + subTotal.ToString();
			}
		}

		private void tbGuestName_Leave(object sender, EventArgs e)
		{
			if (tbGuestName.Text != "")
			{
				//Clears the error provider for guest name.
				epGuestName.Clear();

				//New instance of UseDatabase class.
				UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");

				//Connect database.
				useDb.ConnectToDatabase();

				//Execute query to autofill room data from the room number provided.
				string queryString = "SELECT GuestName FROM [Guest] WHERE Guestname = '" + tbGuestName.Text + "'";

				//Execute query to check for matches in the database.
				OleDbDataReader dbReader = useDb.ExecuteQuery(queryString);

				//If there are rows in the result from the ExecuteQuery then the check was successful meaning there was a match.
				if (dbReader != null && dbReader.HasRows)
				{
					epGuestName.Clear();
				}
				else
				{
					epGuestName.SetError(tbGuestName, "Guest not found");
				}
			}
		}

		private void tbNoDays_TextChanged(object sender, EventArgs e)
		{
			if (Int32.TryParse(tbRoomRate.Text, out second) && Int32.TryParse(tbNoDays.Text, out first))
			{
				subTotalDays = (first * second);
				subTotal = subTotalPeople + subTotalDays;
				tbSubTotal.Text = "R" + subTotal.ToString();
			}
		}

		private void tbRoomNum_TextChanged(object sender, EventArgs e)
		{
			
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Creates a connection to the database.
            OleDbConnection oleConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ..\\..\\App_Data\\database.accdb; Persist Security Info=False; ");
            OleDbCommand delcmd = new OleDbCommand();
            oleConn.Open();

            //Checks which row is selected to delete.
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow delrow = dataGridView1.Rows[i];
                if (delrow.Selected == true)
                {
                    try
                    {
                        //Gets the cell value.
                        int ID = Convert.ToInt32(dataGridView1.Rows[i].Cells["ReservationID"].Value);
                        string roomNum = Convert.ToString(dataGridView1.Rows[i].Cells["RoomNum"].Value);
                        //Removes the row from the grid view and the database.
                        dataGridView1.Rows.RemoveAt(i);
                        //Updates the database.
                        delcmd.CommandText = "DELETE FROM Reservation WHERE ReservationID =" + ID + "";
                        delcmd.Connection = oleConn;
                        delcmd.ExecuteNonQuery();
                        delcmd.CommandText = "UPDATE [Room] Set [Status] = 'Avaialable', [NoOfPeople] = 0 WHERE [RoomNumber] = '" + roomNum + "'";
                        delcmd.Connection = oleConn;
                        delcmd.ExecuteNonQuery();
                        //Message box to inform the user the update was a success.
                        MessageBox.Show("Reservation removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch (Exception ex)
                    {
                        //Message box passing the error.
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            oleConn.Close();
        }

        private void tbRoomNum_Leave(object sender, EventArgs e)
		{
			if (tbRoomNum.Text != string.Empty)
			{
				//New instance of the UseDatabase class
				UseDatabase useDb = new UseDatabase("..\\..\\App_Data\\database.accdb");

				//Connect to the database
				useDb.ConnectToDatabase();

				//Query to autofill the rooms data from the room number provided
				string queryString = "SELECT Status,RoomType, RoomRate FROM [Room] WHERE RoomNumber = '" + tbRoomNum.Text + "'";

				//Execute Query to check for matches
				OleDbDataReader dbReader = useDb.ExecuteQuery(queryString);

				//If the query executed it means there was a match
				if (dbReader != null && dbReader.HasRows)
				{

					if (dbReader.Read())
					{
						string roomStatus = dbReader[0].ToString();
						if (roomStatus == "Available")
						{
							tbRoomType.Text = dbReader[1].ToString();
							tbRoomRate.Text = dbReader[2].ToString();
							roomRate = Convert.ToInt32(tbRoomRate.Text);
							tbSubTotal.Text = "R" + tbRoomRate.Text;
							subTotal = Convert.ToInt32(tbNoDays.Text) * roomRate;
							epStatus.Clear();
							epGuestName.Clear();
							epRoomNum.Clear();
						}
						else
						{
							epStatus.SetError(tbRoomNum, "Room not available");
						}
					}
				}
				else
				{
					epRoomNum.Clear();
					epRoomNum.SetError(tbRoomNum, "Room number not found");
				}
			}
			else
			{
				epRoomNum.SetError(tbRoomNum, "Please enter a room number");
			}

		}

		
	}
}
