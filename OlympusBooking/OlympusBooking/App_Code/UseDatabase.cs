﻿////////////////////////////////////////////////////////////////////////////////////////////////////
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

        //Registers a new user on the database (requiring admin password to do so)
        public string RegisterUser(string userName, string pass, string amdinPass)
        {
            try
            {
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = (@"INSERT INTO User([Username],[Password])
                                   VALUES('" + userName + "','" + pass + "')");
                cmd.ExecuteNonQuery();
                return "success";
            }
            catch (OleDbException)
            {
                return "fail";
            }                
                        
        }
        #endregion

        //Adds a new guest to the guest table.
        public string addGuest(string fName,string lName,string add,string number,string gender, string email,string status)
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
        public string CheckIn(string sName)
        {
            try
            {
                String myQuery = "UPDATE [Guest] Set [Status] = 'Checked-In' WHERE [GuestName] = '" + sName + "'";
                OleDbCommand cmd = new OleDbCommand(myQuery, conn);
                cmd.ExecuteNonQuery();

                return "success";
            }
            catch (OleDbException)
            {
                return "fail";
            }
        }
       
    }
}