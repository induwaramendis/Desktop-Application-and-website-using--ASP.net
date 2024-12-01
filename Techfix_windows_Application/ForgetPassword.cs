using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.VariantTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Techfix_windows_Application
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login frms = new Login();
            frms.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
            // using (SqlConnection conn = new SqlConnection(connStr)) 
            {
                conn.Open(); string query = "SELECT Password FROM Admins WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string password = reader["Password"].ToString();
                    SendPasswordEmail(email, password);
                    MessageBox.Show("Password has been sent to your email.");
                    // MessageBox.Show(this.GetType(), "alert", "alert('Password has been sent to your email.');", true);
                    Login frms = new Login();
                    frms.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Email not found.");
                  //  ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Email not found!');", true);
                }
            }
            /* string email = textBox1.Text;
             if (IsValidEmail(email))
             {
                 string token = GenerateResetToken();
                 SaveTokenInDatabase(email, token);
                 SendResetEmail(email, token);
                 MessageBox.Show("Password reset link has been sent to your email.");
             }
             else
             {
                 MessageBox.Show("Please enter a valid email address.");
             }*/




        }
        /* private bool IsValidEmail(string email)
         {
             try
             {
                 var mail = new MailAddress(email);
                 return true;
             }
             catch
             {
                 return false;
             }
         }
         private string GenerateResetToken()
         {
             return Guid.NewGuid().ToString(); // Simple token generation
         }
         private void SaveTokenInDatabase(string email, string token)
         {
             SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Techfix.mdf;Integrated Security=True;Encrypt=False");
            // using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 string query = "UPDATE Admins SET ResetToken = @token, ResetTokenExpiry = @expiry WHERE Email = @Email";
                 using (SqlCommand command = new SqlCommand(query, conn))
                 {
                     command.Parameters.AddWithValue("@token", token);
                     command.Parameters.AddWithValue("@expiry", DateTime.Now.AddHours(1));
                     command.Parameters.AddWithValue("@Email", email);
                     conn.Open();
                     command.ExecuteNonQuery();
                 }
             }
         }*/

        private void SendPasswordEmail(string email, string password) {
            MailMessage mail = new MailMessage();
            mail.To.Add(email);
            mail.From = new MailAddress("techfixcomputershop@gmail.com");
            mail.Subject = "Your Password";
            mail.Body = $"Your password is: {password}";
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; // Your SMTP server address
            smtp.Port = 587; // Your SMTP port
            smtp.Credentials = new System.Net.NetworkCredential("techfixcomputershop@gmail.com", "ufve rewy wdfs vvpf");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    
}
