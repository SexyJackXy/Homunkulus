using DocumentFormat.OpenXml.Vml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homunkulus
{
    public partial class loadBackup : Form
    {
        public loadBackup()
        {
            InitializeComponent();
        }

        public string fileName;

        private void import_backup_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = ofd.FileName;
                fileName = ofd.SafeFileName;

                path_tbx.Text = sourceFile;

                StreamReader sr = new StreamReader(sourceFile);

                string content = sr.ReadToEnd();
                Content_rtb.Text = content;
            }

        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Today;
            string date = datetime.ToString("dd/MM/yyyy");

            string source = path_tbx.Text;
            string destination = @"Resources\backupplans\Backup_" + date + ".txt";
            if(source.Length == 0 )
            {
                MessageBox.Show(" You need to Import a File at first");
            }
            else
            {
                File.Copy(source, destination);
            }
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
            History his = new History();
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
            History hs = new History();
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
