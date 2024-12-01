using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace TechFix
{
    public partial class SupplierLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            
         
       
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
           // using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Techfix.mdf;Integrated Security=True;Encrypt=False"))
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM Suppliers WHERE Username = @Username AND Password = @Password AND UserType = @UserType";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@UserType", DropDownList1.SelectedItem.ToString());
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    
                    if (DropDownList1.SelectedIndex == 0)
                    {
                        Response.Write("<script>alert('you are logged in as " + DropDownList1.SelectedItem.ToString() + "')</script>");
                        Server.Transfer("Supplier01_Inventory.aspx");
                    }
                    else if (DropDownList1.SelectedIndex == 1)
                    {
                        Response.Write("<script>alert('you are logged in as " + DropDownList1.SelectedItem.ToString() + "')</script>");
                        Server.Transfer("Supplier02_Inventory.aspx");
                    }
                    else if (DropDownList1.SelectedIndex == 2)
                    {
                        Server.Transfer("SupplierDashboard.aspx");
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('invalid login');", true);
                }
            }

            /* string username = txtUsername.Text;
             string password = txtPassword.Text;

             // Fetch connection string from the configuration file
             SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Techfix.mdf;Integrated Security=True;Encrypt=False");


             {
                 conn.Open();

                 // Modify query to fetch role as well
                 string query = "SELECT COUNT(1) FROM Supplier WHERE Username=@Username AND Password=@Password";
                 SqlCommand cmd = new SqlCommand(query, conn);
                 cmd.Parameters.AddWithValue("@Username", username);
                 cmd.Parameters.AddWithValue("@Password", password);

                 int count = Convert.ToInt32(cmd.ExecuteScalar());

                 if (count == 1)
                 {
                     // Login successful, redirect to Admin Dashboard
                     Response.Redirect("Home Page.aspx");
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