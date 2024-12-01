using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFix
{
    public partial class AdminaddedInventories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadInventories();
            }
        }

        private void LoadInventories()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
            // using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Inventory";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    InventoryRequestRepeater.DataSource = dt;
                    InventoryRequestRepeater.DataBind();
                }
            }

        }
    }
}