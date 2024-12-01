using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TechFix
{
    public partial class Login_Page : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            

            
        }

        protected void uemail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            UserService.UserServiceSoapClient client = new UserService.UserServiceSoapClient();
            bool isValidUser = client.Login(username, password);

            if (isValidUser)
            {
                string script = "<script>alert('Login successful!'); " +
                    "window.location='CustomerHomePage.aspx';</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "LoginSuccess", script);
               
            }
            else
            {
                // Login failed, show alert message
                Response.Write("<script>alert('Login failed. Please check your username and password.');</script>");
            }
            /* string username = txtUsername.Text;
             string password = txtPassword.Text;

             // Fetch connection string from the configuration file
             SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Techfix.mdf;Integrated Security=True;Encrypt=False");


             {
                 conn.Open();

                 // Modify query to fetch role as well
                 string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";
                 SqlCommand cmd = new SqlCommand(query, conn);
                 cmd.Parameters.AddWithValue("@Username", username);
                 cmd.Parameters.AddWithValue("@Password", password);

                 int count = Convert.ToInt32(cmd.ExecuteScalar());

                 if (count == 1)
                 {
                     // Login successful, redirect to Admin Dashboard
                     Response.Redirect("CustomerHomePage.aspx");
                 }
                 else
                 {
                     // Login failed
                     Response.Write("<script>alert('Login failed. Please check your username and password.');</script>");
                 }
             }*/
        }
    }
}