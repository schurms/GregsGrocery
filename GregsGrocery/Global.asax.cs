using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace GregsGrocery
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //GregsGrocery.Operators u = new GregsGrocery.Operators();
            //u.Roles["Default"] = "Deny";
            //u.Roles["About"] = "Deny";
            //u.Roles["Contact"] = "Deny";
            //Session["user"] = u;
        }
    }
}