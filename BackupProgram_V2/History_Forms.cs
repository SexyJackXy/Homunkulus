using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text.Encodings;
using ClosedXML.Excel;

namespace BackupProgram_V2
{
    public partial class History_Forms : Form
    {
        public History_Forms()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Forms f1 = new Home_Forms();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string path = @"History.xlsx";

        private void Form2_Load(object sender, EventArgs e)
        {
            using (var wb = new XLWorkbook(path, XLEventTracking.Disabled))
            {
                var ws = wb.Worksheet(1);
                DataTable dt = ws.RangeUsed().AsTable().AsNativeDataTable();

                foreach(DataColumn dc in dt.Columns)
                {
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                }
                foreach(DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr.ItemArray);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saves_Forms f3 = new Saves_Forms();
            f3.ShowDialog();
            this.Close();
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings_Forms f4 = new Settings_Forms();
            f4.ShowDialog();
            this.Close();
        }
    }
}
