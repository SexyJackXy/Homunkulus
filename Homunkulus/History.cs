using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homunkulus
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        string path = @"Resources\database.xlsx";

        private void History_Load(object sender, EventArgs e)
        {
            using (var wb = new XLWorkbook(path, XLEventTracking.Disabled))
            {
                var ws = wb.Worksheet(1);
                DataTable dt = ws.RangeUsed().AsTable().AsNativeDataTable();

                foreach (DataColumn dc in dt.Columns)
                {
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                }
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr.ItemArray);
                }
            }
        }
        private void create_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overview ov = new Overview();
            ov.Show();
            this.Close();
        }
        private void home_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landingpage lp = new Landingpage();
            lp.Show();
            this.Close();
        }
        private void plans_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            History hs = new History();
            hs.Show();
            this.Close();
        }
    }
}
