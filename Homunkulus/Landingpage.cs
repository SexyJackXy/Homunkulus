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
            string path = @"Resources\backupplans";

            //Loading Number of Backuppläne
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
            int count = dir.GetFiles().Length;

            numb_backup.Text = Convert.ToString(count);

            //Loading Times Executed a Backup

            //numb_execute.Text= Convert.ToString();
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
