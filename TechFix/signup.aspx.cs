using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Net.Mail;


namespace TechFix
{
    public partial class signup : System.Web.UI.Page
    {
       // SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\TechFix\TechFix\App_Data\DatabaseTechfix.mdf;Integrated Security = True ");

       // public object MessageBox { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
          //  if (con.State == ConnectionState.Open)
           // {
           //     con.Close();
//
           // }
           // con.Open();
        }

        protected void username_TextChanged(object sender, EventArgs e)
        {

        }

        protected void signbtn_Click(object sender, EventArgs e)
        {




            /* SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Techfix.mdf;Integrated Security=True;Encrypt=True");
             con.Open();
             string loginQuery = "INSERT INTO Users  VALUES (@Username, @Email, @Password)";
             SqlCommand cmd = new SqlCommand(loginQuery, con);
             cmd.Parameters.AddWithValue("@Username",username.Text);
             cmd.Parameters.AddWithValue("@Email", email.Text);
             cmd.Parameters.AddWithValue("@Password", password.Text);

             int count = (int)cmd.ExecuteScalar();
             con.Close();
             if (count > 0)
             {


                 Response.Write("<script>alert('register successfully');</script>");
                 Response.Redirect("Login Page.aspx");
             }
             else
             {
                 Response.Write("<script>alert('register unsuccessfully');</script>");
             }
            */
          

        }

        protected void btnRegister_Click(object sender, EventArgs e)
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

                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");

                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, Email, Password) VALUES (@Username, @Email, @Password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                    SendWelcomeEmail(email, username);
                    string script = "<script>alert('Register successful!'); " +
                   "window.location='Login Page.aspx';</script>";
                    ClientScript.RegisterStartupScript(this.GetType(), "LoginSuccess", script);
                }
            }

            void SendWelcomeEmail(string userEmail, string userName) 
            {
                try
                { 
                    MailMessage mail = new MailMessage();
                   SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com"); 
                    mail.From = new MailAddress("techfixcomputershop@gmail.com"); 
                    mail.To.Add(userEmail); 
                    mail.Subject = "Welcome to Techfix!!!"; 
                    mail.Body = $"Hi {userName},\n\nWelcome to our service! We're excited to have you on board.\n\nBest regards,\nTechfix Computer Shop"; 
                    SmtpServer.Port = 587; 
                    SmtpServer.Credentials = new System.Net.NetworkCredential("techfixcomputershop@gmail.com", "ufve rewy wdfs vvpf"); 
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                }
                catch (Exception ex) 
                { 
                    Response.Write("<script>alert('An error occurred while sending the email: " + ex.Message + "');</script>");
                } 
            }
        }
    }
}