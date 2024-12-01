using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Techfix_windows_Application
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login frms = new Login();
            frms.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String username = textBox1.Text;
            String password = textBox3.Text;
            String email = textBox2.Text; string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string passwordPattern = @"(?=(?:.*?\d){6})";


            // Check if password meets the criteria
            if (!Regex.IsMatch(password, passwordPattern))
            {
                MessageBox.Show("Password must contain at least 6 numbers");
                return;
            }
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            else
            {

                if (ValidateSignup(username, email, password))
                {
                    MessageBox.Show("Register successful");

                    Login frms = new Login();
                    frms.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Register Failed..Try Again");
                }
            }
        }

        private bool ValidateSignup(string username, string email,string password)
        {
            SqlConnection conn =  new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");

            //  using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Admins (Username, Email, Password) VALUES (@Username, @Email, @Password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        cmd.ExecuteNonQuery();
                        return true;
                        //  Home_Page frms = new Home_Page();
                        //  frms.Show();
                        //  this.Hide();



                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error: {ex.Message}");
                    return false;
                }

            }
        }
    }
}
