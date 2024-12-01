using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Techfix_windows_Application
{
    public partial class Comparison : Form
    {
        Service.WebService1 wbService = new Service.WebService1();

        public Comparison()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home_Page frms = new Home_Page();
            frms.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = wbService.returnTable();
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
