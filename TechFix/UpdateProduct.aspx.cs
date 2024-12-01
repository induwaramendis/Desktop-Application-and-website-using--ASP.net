using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace TechFix
{
    public partial class UpdateProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        /*protected void LoadProductDetails()
        {

            string pid = Request.QueryString["update"];
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Techfix.mdf;Integrated Security=True;Encrypt=False");
            if (!string.IsNullOrEmpty(pid)) // Ensure pid is not null or empty
            {

                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM AddProducts WHERE ItemId=@ItemId", conn);
                    cmd.Parameters.AddWithValue("@ItemId", pid);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    { // Fill the controls with product details
                        txtName.Text = reader["Name"].ToString();
                        txtPrice.Text = reader["Price"].ToString();
                        ddlCategory.SelectedValue = reader["Category"].ToString();
                        imgProduct.ImageUrl = "../uploaded_img/" + reader["Image"].ToString();
                        hdnOldImage.Value = reader["Image"].ToString();
                    }
                }
            }
            else
            {
                lblMessage.Text = "Product ID is missing!";
            }

        }*/
        protected void btnUpdate_Click(object sender, EventArgs e)
        {


           // SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Techfix.mdf;Integrated Security=True;Encrypt=False");

            // string pid = Request.Form["ItemId"];
            string name = txtName.Text;
            string price = txtPrice.Text;
            string category = ddlCategory.SelectedValue;
            string oldImage = hdnOldImage.Value;

            string newImage = fileUploadImage.HasFile ? fileUploadImage.FileName : oldImage;

            if (fileUploadImage.HasFile)
            {
                string imageFileName = fileUploadImage.FileName;
                string imageFolderPath = Server.MapPath("~/uploaded_img/") + imageFileName;

                if (fileUploadImage.PostedFile.ContentLength > 2000000)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Image size is too large');", true);
                }
                else
                {
                    fileUploadImage.SaveAs(imageFolderPath);
                    //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Techfix.mdf;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Techfix.mdf;Integrated Security=True;Encrypt=False");
                    //using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT COUNT(1) FROM Products WHERE Name=@Name";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", name);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
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

        
    }
}