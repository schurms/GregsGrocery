using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace GregsGrocery
{
    public class Operators
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Dictionary<string, string> Roles { get; set; }

        public const string CONNECTION_STRING = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"|DataDirectory|Grocery_Master.accdb\";Persist Security Info=True";

        public Operators()
        {
        }

        public Operators(string username, string password)
        {
            OleDbConnection conn = new OleDbConnection(CONNECTION_STRING);

            string query = string.Format("SELECT * FROM qryOperatorPermissions WHERE OperatorName = \"{0}\" AND OperatorPin = \"{1}\"", username, password);

            OleDbCommand cmd = new OleDbCommand(query, conn);

            conn.Open();

            OleDbDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                this.ID = int.Parse(reader.GetValue(0).ToString());
                this.Username = reader.GetString(1).ToString();
                this.Password = reader.GetString(2).ToString();
            }
            conn.Close();
            
        }

        public static bool ValidUser(string username, string password)
        {
            OleDbConnection conn = new OleDbConnection(CONNECTION_STRING);

            string query = string.Format("SELECT TOP 1 * FROM tblOperators WHERE tblOperators.OperatorName = \"{0}\" AND tblOperators.OperatorPin = \"{1}\"", username, password);

            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            var hasRows = reader.HasRows;
            conn.Close();

            return hasRows;
        }
    }


}