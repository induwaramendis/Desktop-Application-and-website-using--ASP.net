using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TechFix
{
    public partial class SupplierSignup : System.Web.UI.Page
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
                    string query = "INSERT INTO Suppliers (Username, Email,Password, UserType) VALUES (@Username,@Email,@Password,@UserType)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@UserType", DropDownList1.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    string script = "<script>alert('Register successful!'); " +
                    "window.location='SupplierLogin.aspx';</script>";
                    ClientScript.RegisterStartupScript(this.GetType(), "LoginSuccess", script);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}