using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GregsGrocery
{
    public partial class EditProducts : System.Web.UI.Page
    {
        string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/Grocery_Master.accdb;Persist Security Info=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            OleDbConnection dbConn = new OleDbConnection(conString);

            try
            {
                OleDbCommand dbCmd = new OleDbCommand("SELECT * FROM tblProducts WHERE ProductID = " + Session["productid"], dbConn);
                dbConn.Open();
                using (OleDbDataReader dbReader = dbCmd.ExecuteReader())
                {
                    dbReader.Read();
                    lblID.Text = dbReader["ProductID"].ToString();
                    txtDesc.Text = dbReader["ProductDescription"].ToString();
                    txtPrice.Text = dbReader["ProductPrice"].ToString();
                }
            }
            catch
            {
                lblID.Text = "0";
            }

            dbConn.Close();
        }
        

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string query = "";

            if(lblID.Text == "0")
            {
                query = string.Format("INSERT INTO tblProducts (Description,Price) VALUES (\"{0}\", {1})", txtDesc.Text, txtPrice.Text);
            }
            else
            {
                query = string.Format("UPDATE tblProducts SET Description = \"{0}\", Price={1} WHERE ID = {2}", txtDesc.Text, txtPrice.Text, lblID.Text);
            }

            OleDbConnection dbConn = new OleDbConnection(conString);
            OleDbCommand dbCmd = new OleDbCommand(query, dbConn);
            dbConn.Open();
            dbCmd.ExecuteNonQuery();
            dbConn.Close();
            Response.Redirect("Default");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM tblProduct WHERE ID =" + lblID.Text;

            OleDbConnection dbConn = new OleDbConnection(conString);
            OleDbCommand dbCmd = new OleDbCommand(query, dbConn);
            dbConn.Open();
            dbCmd.ExecuteNonQuery();
            dbConn.Close();
        }
    }
}