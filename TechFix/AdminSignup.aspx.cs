using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace TechFix
{
    public partial class AdminSignup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string passwordPattern = @"(?=(?:.*?\d){6})";


            // Check if password meets the criteria
            if (!Regex.IsMatch(password, passwordPattern))
            {
                Response.Write("<script>alert('Password must contain at least 6 numbers.');</script>");
                return;
            }
            if (!Regex.IsMatch(email, emailPattern))
            {
                Response.Write("<script>alert('Please enter a valid email address.');</script>");
                return;
            }
            else
            {

                // string connectionString = ConfigurationManager.ConnectionStrings["Techfix"].ConnectionString;
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
                //using (SqlConnection con = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Admins (Username, Email, Password) VALUES (@Username, @Email, @Password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                    string script = "<script>alert('Register successful!'); " +
                    "window.location='AdminLogin.aspx';</script>";
                    ClientScript.RegisterStartupScript(this.GetType(), "LoginSuccess", script);
                }
            }

        }
    }
}