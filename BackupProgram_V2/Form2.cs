using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text.Encodings;
using ClosedXML.Excel;

namespace BackupProgram_V2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
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
            Saves f3 = new Saves();
            f3.ShowDialog();
            this.Close();
        }
    }
}
