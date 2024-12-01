using System;
using System.Data.SqlClient;



namespace SupplierService
{
    public class SupplierServiceSoapClient
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Techfix.mdf;Integrated Security=True;Encrypt=False";

        public bool Login(string username, string password)

        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Suppliers WHERE Username =@Username AND Password=@Password";

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
            catch (Exception ex)
            {

                LogError(ex);
                return false;


            }
        }
        private void LogError(Exception ex)
        { 
            System.IO.File.AppendAllText(@"C:\ErrorLog.txt",DateTime.Now.ToString() + ": " + ex.ToString() + Environment.NewLine);
        }

    }
}