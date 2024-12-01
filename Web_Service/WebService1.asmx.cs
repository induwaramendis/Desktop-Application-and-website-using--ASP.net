using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Web_Service
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

       

        [WebMethod]
        public DataTable returnTable()
        {
            DataTable dt = new DataTable("tbl_Employee");
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Supplier01", typeof(string));
            dt.Columns.Add("Supplier02", typeof(string));
            dt.Rows.Add("Lenovo Legion 9 | 16IRX9 | i9-14900HX | RTX 4090", "₨1,395,000.00", "₨1,405,000.00");
            dt.Rows.Add("LENOVO IDEAPAD 5 | 2-in-1 |INTEL CORE 7 14TH GEN", "₨319,000.00", "₨315,000.00");
            dt.Rows.Add("APPLE MACBOOK AIR M3 | 8GB 256GB | 13\" | (2024)", "₨349,000.00", "₨365,000.00");
            return dt;
        }



       
        public class UserServiceSoapClient
        {
            private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False";

            [WebMethod]
            public bool Login(string username, string password)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))


                {
                    string query = "SELECT COUNT(*) FROM Users WHERE Username =@Username AND Password=@Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))

                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;



                    }
                }
            }
        }
        public class AdminServiceSoapClient
        {
            private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False";

            [WebMethod]
            public bool AdminLogin(string username, string password)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))


                {
                    string query = "SELECT COUNT(*) FROM Admins WHERE Username =@Username AND Password=@Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))

                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;



                    }
                }
            }
        }


    }
}
