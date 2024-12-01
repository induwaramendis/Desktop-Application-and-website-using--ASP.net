using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFix
{
    public partial class Quotation_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddQuotation_Click(object sender, EventArgs e)
        {
            string CName = txtcustomername.Text;
            string item = txtitem.Text;
            DateTime date = Convert.ToDateTime(txtQuotationDate.Text);
            string spec= txtspec.Text;
            int Num = Convert.ToInt32(txtNumber.Text);


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");


            string query = "INSERT INTO Quotations (CustomerName, Item, Date, Specification, Number) " + " VALUES (@CustomerName, @Item, @Date, @Specification, @Number)";


            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerName", CName);
                cmd.Parameters.AddWithValue("@Item", item);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Specification", spec);
                cmd.Parameters.AddWithValue("@Number", Num);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            Response.Write("<script>alert('Quotation sent successfully!');</script>");
            txtcustomername.Text = "";
            txtitem.Text = "";
            txtQuotationDate.Text = "";
            txtspec.Text = "";
            txtNumber.Text = "";



        }
    }
}