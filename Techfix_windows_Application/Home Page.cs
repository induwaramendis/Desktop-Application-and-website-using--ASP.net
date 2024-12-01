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
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();

        }

       

        private void button2_Click(object sender, EventArgs e)
        {

            Comparison frms = new Comparison();
            frms.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Inventory_Management frms = new Inventory_Management();
            frms.Show();
            this.Hide();
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
           /* CenterControl(button1); 
            CenterControl(button2);
            CenterControl(button3); 
            CenterControl(label1);
            CenterControl(button4); 
            CenterControl(button5); */
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CustomerOrders frms = new CustomerOrders();
            frms.Show();
            this.Hide();
        }
        /* private void CenterControl(Control ctrl) 
{ 
    ctrl.Left = (this.ClientSize.Width - ctrl.Width) / 2;
    ctrl.Top = (this.ClientSize.Height - ctrl.Height) / 2; 
}*/
    }
}
