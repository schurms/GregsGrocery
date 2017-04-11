using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GregsGrocery
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var valid = GregsGrocery.Operators.ValidUser(txtUserName.Text, txtPassword.Text);

            if(valid)
            {
                GregsGrocery.Operators user = new Operators(txtUserName.Text, txtPassword.Text);
                Session["user"] = user;
                Response.Redirect("~/Default");
            }
            else 
            {
                lblInfo.ForeColor = System.Drawing.Color.Red;
                lblInfo.Text = "Invalid user credentials";
            }
        }
    }
}