using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ClosedXML.Excel;

namespace Techfix_windows_Application
{
    public partial class CustomerOrders : Form
    {
        public CustomerOrders()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataView DV = dataGridView1.DataSource as DataView;
                if (DV != null)
                    DV.RowFilter = textBox1.Text;
                label1.Text = $"Total Records:{dataGridView1.RowCount}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Excel WorkBook| * .xlsx",
                Multiselect = false
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataTable dt = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        bool isFirstRow = true;
                        var rows = workbook.Worksheet(1).RowsUsed();
                        foreach (var row in rows)
                        {
                            if (isFirstRow)
                            {
                                foreach (IXLCell cell in row.Cells())
                                    dt.Columns.Add(cell.Value.ToString());
                                isFirstRow = false;
                            }
                            else
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells())
                                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();

                            }
                        }
                        dataGridView1.DataSource = dt.DefaultView;
                        label1.Text = $"Total Records:{dataGridView1.RowCount}";
                        Cursor.Current = Cursors.WaitCursor;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home_Page fr = new Home_Page();
            fr.Show();
            this.Close();
        }
    }
}
