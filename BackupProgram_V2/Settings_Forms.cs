using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BackupProgram_V2
{
    public partial class Settings_Forms : Form
    {
        public Settings_Forms()
        {
            InitializeComponent();
        }



        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Forms f1 = new Home_Forms();
            f1.ShowDialog();
            this.Close();
        }

        private void his_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            History_Forms f2 = new History_Forms();
            f2.ShowDialog();
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saves_Forms f3 = new Saves_Forms();
            f3.ShowDialog();
            this.Close();
        }

        private void Compress_btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Import_Forms f5 = new Import_Forms();
            f5.ShowDialog();
            this.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
