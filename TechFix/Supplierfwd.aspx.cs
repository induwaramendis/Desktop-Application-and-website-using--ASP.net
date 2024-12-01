using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFix
{
    public partial class Supplierfwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
            // using (SqlConnection conn = new SqlConnection(connStr)) 
            {
                conn.Open(); string query = "SELECT Password FROM Suppliers WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string password = reader["Password"].ToString();
                    SendPasswordEmail(email, password);
                    Response.Write("Password has been sent to your email.");
                   // ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Password has been sent to your email.');", true);
                  //  Response.Redirect("SupplierLogin.aspx");

                }
                else
                {
                    Response.Write("Email not found.");
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Email not found!');", true);
                }
            }
        }


        private void SendPasswordEmail(string email, string password)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(email);
            mail.From = new MailAddress("techfix613@gmail.com");
            mail.Subject = "Your Password";
            mail.Body = $"Your password is: {password}";
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; // Your SMTP server address
            smtp.Port = 587; // Your SMTP port
            smtp.Credentials = new System.Net.NetworkCredential("techfix613@gmail.com", "crsv cehr tkwp rdwa");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }

    }
}
