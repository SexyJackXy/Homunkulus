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
            //Updating Number of Backuppläne
            string path = @"Resources\database.xlsx";

            IXLWorkbook wb = new XLWorkbook(path);
            IXLWorksheet ws = wb.Worksheet(1);

            var backupplans = ws.RowsUsed().Count();

            numb_backup.Text = Convert.ToString(backupplans);
        }
    }
}
