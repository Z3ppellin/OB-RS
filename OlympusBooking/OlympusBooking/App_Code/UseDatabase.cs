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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;

namespace OlympusBooking
{   
    //Class to handle all database methods.
    public class UseDatabase
    {
        //Declares the databse path.
        OleDbConnection conn = new OleDbConnection();
        string databasePath = "";

        //Recieves the database path.
        public UseDatabase(string databasePath)
        {
            this.databasePath = databasePath;
        }

        #region Connect/Disconnect
        //Connect to database.
        public void ConnectToDatabase()
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = '" + databasePath + "'; Persist Security Info=False; ");
            conn.Open();
        }

        //Disconnect from database
        public void DisconnectDatabase()
        {
            conn.Close();
        }
        #endregion

        #region Database Methods
        //Executes a query and return the result.
        public OleDbDataReader ExecuteQuery(string query)
        {
            try
            {
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                return cmd.ExecuteReader();
            }
            catch (OleDbException)
            {
                return null;
            }
        }

        //Registers a new user on the database
        public string addUser(string userName, string pass)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ..\\..\\App_Data\\database.accdb");

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO Users([Username],[Password]) VALUES (@sUserName,@sPassword)";
                cmd.Parameters.AddWithValue("@sUserName", userName);
                cmd.Parameters.AddWithValue("@sPassword", pass);

                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                return "success";
            }
            catch (OleDbException)
            {
                return "fail";
            }                
                        
        }

        //Adds a new guest to the guest table.
        public string addGuest(string fName, string lName, string add, string number, string gender, string email, string status)
        {
            try
            {
                String myQuerry = "INSERT INTO Guest(GuestName,GuestSurname,GuestAddress,GuestContactNumber,GuestGender,GuestEmail,Status) " +
                                  "VALUES('" + fName + "','" + lName + "','" + add + "','" + number + "','" + gender + "','" + email + "','" + status + "')";

                OleDbCommand cmd = new OleDbCommand(myQuerry, conn);
                cmd.ExecuteNonQuery();

                return "success";
            }
            catch (OleDbException)
            {
                return "fail";
            }
        }

        //Adds a new room to the hotel system (e.g through expansion).
        public string addRoom(string roomNum, string roomType, string roomRate)
        {
            try
            {
                String myQuery = "INSERT INTO Room(RoomNumber,RoomType,RoomRate) " +
                                 "VALUES('" + roomNum + "','" + roomType + "','" + roomRate + "')";

                OleDbCommand cmd = new OleDbCommand(myQuery, conn);
                cmd.ExecuteNonQuery();

                return "success";
            }
            catch (OleDbException)
            {
                return "fail";
            }
        }

        //Updates the neccessary tables so the user status is checked-in.
        public string CheckIn(string sName, string CheckInDate, string roomNo, string noOfDays, string noPeople, int subTotal)
        {
            try
            {
                //Updates the guest as checked in.
                String myQuery = "UPDATE [Guest] Set [Status] = 'Checked-In' WHERE [GuestName] = '" + sName + "'";
                OleDbCommand cmd1 = new OleDbCommand(myQuery, conn);
                cmd1.ExecuteNonQuery();
                
                //Updates the Room to be unavailable.
                String myQuery2 = "UPDATE [Room] Set [Status] = 'Checked-In' WHERE [RoomNumber] = '" + roomNo + "'";
                OleDbCommand cmd2 = new OleDbCommand(myQuery2, conn);
                cmd2.ExecuteNonQuery();

                //Inserts a new entry into the CheckIn table.
                String myQuery3 = "INSERT INTO CheckIn(GuestName,RoomNum,CheckInDate, NoOfDays, NoOfPeople, TotalDue) " +
                                  "VALUES('" + sName.ToLower() + "','" + roomNo + "','" + CheckInDate + "','" + noOfDays + "','" + noPeople + "', '" + subTotal + "')";
                OleDbCommand cmd3 = new OleDbCommand(myQuery3, conn);
                cmd3.ExecuteNonQuery();

                return "success";
            }
            catch (OleDbException)
            {
                return "fail";
            }
        }

        public string CheckOut(string guestName, string roomNo, string checkOutDate)
        {
            try
            {
                //Updates the guest as checked out.
                String myQuery = "UPDATE [Guest] Set [Status] = 'Checked-out' WHERE [GuestName] = '" + guestName + "'";
                OleDbCommand cmd1 = new OleDbCommand(myQuery, conn);
                cmd1.ExecuteNonQuery();

                //Updates the Room to be available.
                String myQuery2 = "UPDATE [Room] Set [Status] = 'Available' WHERE [RoomNumber] = '" + roomNo + "'";
                OleDbCommand cmd2 = new OleDbCommand(myQuery2, conn);
                cmd2.ExecuteNonQuery();

                //Updates the entry in the CheckIn table.
                String myQuery3 = "UPDATE [CheckIn] Set [CheckOutDate] = '" + checkOutDate + "' WHERE [GuestName] = '" + guestName + "'";
                OleDbCommand cmd3 = new OleDbCommand(myQuery3, conn);
                cmd3.ExecuteNonQuery();

                return "success";
            }
            catch (OleDbException)
            {
                return "fail";
            }
        }
        #endregion
    }
}