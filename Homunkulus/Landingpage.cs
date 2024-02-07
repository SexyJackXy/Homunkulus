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
            var path = @"..\..\..\backupplans";
            var runPath = @"..\..\..\logs";

            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
            var count = dir.GetFiles().Length;
            numb_backup.Text = Convert.ToString(count);

            System.IO.DirectoryInfo dir2 = new System.IO.DirectoryInfo(runPath);
            var runCount = dir2.GetFiles().Length;
            numb_execute.Text = Convert.ToString(runCount);
        }
        private void create_btn_Click(object sender, EventArgs e)
        {     
            this.Hide();
            createBackup ov = new createBackup();
            ov.ShowDialog();
            this.Close();  
        }
        private void show_backup_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            savedBackups his = new savedBackups();
            his.ShowDialog();
            this.Close();
        }
        private void create_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            createBackup ov = new createBackup();
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
            savedBackups hs = new savedBackups();
            hs.ShowDialog();
            this.Close();
        }
        private void restore_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            loadBackup bps = new loadBackup();
            bps.ShowDialog();
            this.Close();
        }
    }
}
