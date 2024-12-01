using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TechFix
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Fetch connection string from the configuration file
            //  SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");

            UserService.AdminServiceSoapClient client = new UserService.AdminServiceSoapClient();
            bool isValidUser = client.AdminLogin(username, password);

            if (isValidUser)
            {
                string script = "<script>alert('Login successful!'); " +
                    "window.location='AdminDashboard.aspx';</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "LoginSuccess", script);

            }
            else
            {
                // Login failed, show alert message
                Response.Write("<script>alert('Login failed. Please check your username and password.');</script>");
            }
           // {
                //conn.Open();

                // Modify query to fetch role as well
                //string query = "SELECT COUNT(1) FROM Admins WHERE Username=@Username AND Password=@Password";
               // SqlCommand cmd = new SqlCommand(query, conn);
               // cmd.Parameters.AddWithValue("@Username", username);
               // cmd.Parameters.AddWithValue("@Password", password);

               // int count = Convert.ToInt32(cmd.ExecuteScalar());

                //if (count == 1)
               // {
                    // Login successful, redirect to Admin Dashboard
                //    Response.Write("<script>alert('Login Successful....');</script>");
               //     Response.Redirect("AdminDashboard.aspx");
               // }
               // else
             //   {
                    // Login failed
                  //  Response.Write("<script>alert('Login failed. Please check your username and password.');</script>");
               // }
//}
        }
    }
}