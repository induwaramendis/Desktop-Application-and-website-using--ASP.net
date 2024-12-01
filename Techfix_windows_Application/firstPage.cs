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
    public partial class firstPage : Form
    {
        
        public firstPage()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login frms = new Login();
            frms.Show();
            this.Hide();
        }

        private void firstPage_Load(object sender, EventArgs e)
        {

        }
    }
}
