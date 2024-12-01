using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace TechFix
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");

            string query = "INSERT INTO Orders (Item, Name, Date, Note, Number) VALUES (@Item, @Name, @Date, @Note, @Number)";

            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Item",txtOrderID.Text );
                cmd.Parameters.AddWithValue("@Name",txtcustmer.Text);
                cmd.Parameters.AddWithValue("@Date",Convert.ToDateTime(txtOrderDate.Text));
                cmd.Parameters.AddWithValue("@Note", txtnote.Text);
                cmd.Parameters.AddWithValue("@Number", txtnumber.Text);


                Response.Write("<script>alert('Order Placed.. Our agent contact you soon.');</script>");

                txtOrderID.Text = "";
                txtcustmer.Text = "";
                txtnote.Text = "";
                txtnumber.Text = "";
                txtOrderDate.Text = "";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }
    }
}