using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Techfix_windows_Application
{
    public partial class Login : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False";
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login successful");

                Home_Page frms = new Home_Page();
                frms.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");

            }
        }

        private bool ValidateLogin(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM Admins WHERE Username = @Username AND Password = @Password  ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int result = (int)cmd.ExecuteScalar();
                        return result == 1;
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
    
         
                
                
                
            
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Register frms = new Register();
            frms.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ForgetPassword frms = new ForgetPassword();
            frms.Show();
            this.Hide();
        }
    }
}
