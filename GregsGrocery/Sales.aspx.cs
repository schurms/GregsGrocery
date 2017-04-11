using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GregsGrocery
{
    public partial class Sales : System.Web.UI.Page
    {
        static DataSet ds;
        static DataTable dt;
        string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/Grocery_Master.accdb;Persist Security Info=True";
        protected void Page_Load(object sender, EventArgs e)
        {

            OleDbDataAdapter dbAdapter = new OleDbDataAdapter("SELECT * FROM tblSales", conString);
            ds = new DataSet();
            dbAdapter.Fill(ds);
            ddlSelectSale.DataSource = ds.Tables[0];
            ddlSelectSale.DataValueField = "SaleID";
            ddlSelectSale.DataBind();


        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            // tblSales Storage
            // SaleID, SaleTime, OperatorID, Complete (checkbox ( boolean))

            //tblSalesLine Storage
            // SaleLineID, ProductID, SaleID, LinePrice, LineQuantity

            //string query = "";
            //bool blnComplete = false;

            //if(blnComplete = false)
            //{
            //    query = string.Format("INSERT INTO tblSalesLine (ProductID, SaleID, LinePrice, LineQuantity) VALUES ({0}, {1}, {2}, {3})", )
            //}
        }

        protected void btnSelectSale_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(conString);

            string query = string.Format("SELECT * FROM qrySaleLines WHERE SaleID = {0}", ddlSelectSale.Text);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();

            OleDbDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                txtProductPrice.Text = "$" + reader.GetValue(3).ToString();
                txtQuantity.Text = reader.GetValue(4).ToString();
            }
            conn.Close();

            OleDbDataAdapter dbAdapter = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            gvList.DataSource = dt;
            gvList.DataBind();
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {

        }

    }
}