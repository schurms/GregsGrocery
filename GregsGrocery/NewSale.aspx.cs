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
    public partial class NewSale : System.Web.UI.Page
    {

        static DataSet ds;
        string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/Grocery_Master.accdb;Persist Security Info=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter dbAdapter = new OleDbDataAdapter("SELECT * FROM tblProducts", conString);
            ds = new DataSet();
            dbAdapter.Fill(ds);
            gvList.DataSource = ds.Tables[0];
            gvList.DataBind();
        }

        protected void gvList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}