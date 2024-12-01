using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFix
{
    public partial class Messages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
          
            string name = txtname.Text;
            string email = txtemail.Text;
            string number = txtnumber.Text;
            string msg = txtmsg.Text;

        

            {
                conn.Open();
                
                {


                    var insertQuery = "INSERT INTO Messages (Name, Email, Number, Message) VALUES (@Name, @Email, @Number, @Message)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {

                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Number", number);
                        cmd.Parameters.AddWithValue("@Message", msg);
                        cmd.ExecuteNonQuery();
                        // Login successful, redirect to Admin Dashboard
                        Response.Write("<script>alert('Message Sent.');</script>");
                    }
                }
            }
        }
    }
}