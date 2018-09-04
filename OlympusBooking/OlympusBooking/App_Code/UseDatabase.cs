using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace OlympusBooking
{
    public class UseDatabase
    {
        OleDbConnection conn;
        string databasePath = "";

        public UseDatabase(string databasePath)
        {
            this.databasePath = databasePath;
        }

        //Method to connect to database.
        public void ConnectToDatabase()
        { 
        conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
                                        Data Source=" + databasePath);
            conn.Open();
        }

        //Method which executes a query and return the result.
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
    }
}
