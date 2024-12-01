using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TechFix
{
    public partial class Repairs : System.Web.UI.Page
    {

        //   private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Techfix.mdf;Integrated Security=True;Encrypt=False";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
            string billn = billnum.Text;
            string name = txtname.Text;
            string email = txtemail.Text;
            string number = txtnumber.Text;
            string req = txtReq.Text;

         

           
            {
                conn.Open();
                var selectQuery = "SELECT * FROM Repairs WHERE BillNumber = @billn AND Name = @name AND Email = @Email AND Number = @number AND Request = @req";
                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@billn", billn);
                   cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Number", number);
                    cmd.Parameters.AddWithValue("@req", req);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        // Login successful, redirect to Admin Dashboard
                        Response.Write("<script>alert('Requested.');</script>");
                    }

                    else
                    {
                        // Login failed
                        Response.Write("<script>alert('Requested failed.');</script>");
                    }

                }

                var insertQuery = "INSERT INTO Repairs (BillNumber, Name, Email, Number, Request) VALUES (@billn, @name, @Email, @Number, @req)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@billn", billn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Number", number);
                    cmd.Parameters.AddWithValue("@req", req);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        protected void backbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home Page.aspx");
        }

        //private string Sanitize(string input)
        //{
        // Add your sanitization logic here
        //  return input;

        // }

    }
}