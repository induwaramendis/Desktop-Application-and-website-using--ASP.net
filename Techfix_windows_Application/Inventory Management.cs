using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Techfix_windows_Application
{
    public partial class Inventory_Management : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");

        public Inventory_Management()
        {
            InitializeComponent();
        }
        private void update_Inventory()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
            //using (SqlConnection conn = new SqlConnection(connectionString))
            {



                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Inventory", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home_Page frms = new Home_Page();
            frms.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
            // using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = " INSERT INTO Inventory (ItemId, SupplierID,ItemName, Quantity, UnitPrice) VALUES (@ItemId, @SupplierID, @ItemName, @Quantity, @UnitPrice)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemId",textBox1.Text);
                    cmd.Parameters.AddWithValue("@SupplierID",textBox5.Text);
                    cmd.Parameters.AddWithValue("@ItemName",textBox4.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox3.Text);
                    cmd.Parameters.AddWithValue("@UnitPrice", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item added successfully....!");
                    update_Inventory();


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
            {
                conn.Open();
            string query = "DELETE FROM Inventory WHERE ItemId=@ItemId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemId", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted Successfully....!");
                    update_Inventory();

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\4th semester\Techfix.mdf;Integrated Security=True;Encrypt=False");
            {
                conn.Open();
                string query = "UPDATE Inventory SET SupplierID=@SupplierID, ItemName=@ItemName,Quantity=@Quantity,UnitPrice=@UnitPrice WHERE ItemId=@ItemId ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemId", textBox1.Text);
                    cmd.Parameters.AddWithValue("@SupplierID", textBox5.Text);
                    cmd.Parameters.AddWithValue("@ItemName", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox3.Text);
                    cmd.Parameters.AddWithValue("@UnitPrice", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item updated successfully....!");
                    update_Inventory();
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

           
            
                update_Inventory();
            
            
           
        }
    }
}
