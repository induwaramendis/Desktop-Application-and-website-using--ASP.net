using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;






namespace TechFix
{
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddProductButton_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string price = txtprice.Text;
            string category = Category.Text;

            if (Image.HasFile)
            {
                string imageFileName = Image.FileName;
                string imageFolderPath = Server.MapPath("~/uploaded_img/") + imageFileName;

                if (Image.PostedFile.ContentLength > 2000000)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Image size is too large');", true);
                }
                else
                {
                    Image.SaveAs(imageFolderPath);
                    //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Techfix.mdf;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
                    // using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT COUNT(1) FROM Products WHERE Name=@Name";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", name);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count >0 )
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Product name already exists!');", true);
                        }
                        else
                        {
                            query = "INSERT INTO Products (Name, Category, Price, Image) VALUES (@Name, @Category, @Price, @Image)";
                            cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Category", category);
                            cmd.Parameters.AddWithValue("@Price", price);
                            cmd.Parameters.AddWithValue("@Image", imageFileName);

                            cmd.ExecuteNonQuery();
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('New product added!');", true);
                        }
                    }
                }
            }
        }

        protected void backbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminProducts.aspx");
        }

        protected void backbtn_Click1(object sender, EventArgs e)
        {
            Response.Redirect("AdminProducts.aspx");
        }
    }
}