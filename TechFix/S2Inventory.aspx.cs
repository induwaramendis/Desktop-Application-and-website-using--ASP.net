using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFix
{
    public partial class S2Inventory : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void btninsert_Click(object sender, EventArgs e)
        {

            string itemid = TextBox1.Text;
            string supplierid = TextBox2.Text;
            string itemname = TextBox3.Text;
            string quantity = TextBox4.Text;
            string unitprice = TextBox5.Text;
            // string imageFileName = FileUpload1.FileName;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
            if (FileUpload1.HasFile)
            {
                string imageFileName = FileUpload1.FileName;
                string imageFolderPath = Server.MapPath("~/s1inventory/") + imageFileName;

                if (FileUpload1.PostedFile.ContentLength > 2000000)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Image size is too large');", true);
                }
                else
                {
                    FileUpload1.SaveAs(imageFolderPath);


                    {
                        conn.Open();
                        string query = "SELECT COUNT(1) FROM Supplier02 WHERE ItemID=@ItemId";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ItemId", itemid);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Product id already exists!');", true);
                        }
                        else
                        {
                            query = "INSERT INTO Supplier02 (ItemID, SupplierID, ItemName, Quantity, UnitPrice, Image) VALUES (@ItemID, @SupplierID, @ItemName, @Quantity, @UnitPrice, @Image)";
                            cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@ItemID", itemid);
                            cmd.Parameters.AddWithValue("@SupplierID", supplierid);
                            cmd.Parameters.AddWithValue("@ItemName", itemname);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@UnitPrice", unitprice);
                            cmd.Parameters.AddWithValue("@Image", imageFileName);

                            cmd.ExecuteNonQuery();
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('New product added!');", true);
                        }
                    }
                }
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("Supplier02_Inventory.aspx");
        }
    }
}