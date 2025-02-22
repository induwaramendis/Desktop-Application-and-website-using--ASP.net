﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TechFix
{
    public partial class Supplier01_Inventory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindInventory();

            }
        }

        private void BindInventory()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
               // string connString = System.Configuration.ConfigurationManager.ConnectionStrings["Techfix"].ConnectionString;
                string query = "SELECT * FROM Supplier01";
                

                // using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlDataAdapter Adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    Adapter.Fill(dt);

                    ProductsRequestRepeater.DataSource = dt;
                    ProductsRequestRepeater.DataBind();
                }
               


            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
        }

      

        protected void GridInventory1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            // Redirect to login page
            Response.Redirect("SupplierDashboard.aspx");
        }
    }
}