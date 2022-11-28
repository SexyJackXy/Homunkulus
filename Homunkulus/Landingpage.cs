using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Homunkulus
{
    public partial class Landingpage : Form
    {
        public Landingpage()
        {
            InitializeComponent();
        }

        private void Landingpage_Load(object sender, EventArgs e)
        {
            //Loading Number of Backuppläne
            string path = @"Resources\database.xlsx";

            IXLWorkbook wb = new XLWorkbook(path);
            IXLWorksheet wsb = wb.Worksheet(1);

            var backupplans = wsb.RowsUsed().Count();

            numb_backup.Text = Convert.ToString(backupplans);

            //Loading Times Executed a Backup

            IXLWorksheet wse = wb.Worksheet(2);

            var executed = wse.Cell(2, 2).Value;

            numb_execute.Text= Convert.ToString(executed);
        }
        private void create_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overview ov = new Overview();
            ov.ShowDialog();
            this.Close();
        }
        private void show_backup_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            History his = new History();
            his.ShowDialog();
            this.Close();
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
