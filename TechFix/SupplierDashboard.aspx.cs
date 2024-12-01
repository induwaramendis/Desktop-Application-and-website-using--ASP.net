using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFix
{
    public partial class SupplierDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
           
        }

        protected void LogoutButton3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            // Redirect to login page
            Response.Redirect("SupplierLogin.aspx");
        }
    }
}