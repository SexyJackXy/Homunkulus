using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BackupProgram_V2
{
    public partial class Import_Forms : Form
    {
        public Import_Forms()
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

        private void saves_btn_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            History_Forms f2 = new History_Forms();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
