using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
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
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dataGridView1.AllowUserToResizeRows = true;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;

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
            ov.ShowDialog();
            this.Close();
        }
        private void home_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landingpage lp = new Landingpage();
            lp.ShowDialog();
            this.Close();
        }
        private void plans_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            History hs = new History();
            hs.ShowDialog();
            this.Close();
        }
    }
}
