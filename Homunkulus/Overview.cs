using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homunkulus
{
    public partial class Overview : Form
    {
        List<string> folderlist = new List<string>();

        public Overview()
        {
            InitializeComponent();
        }

        private void create_backup_btn_Click(object sender, EventArgs e)
        {

        }

        private void import_backup_btn_Click(object sender, EventArgs e)
        {

        }

        private void src_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = fbd.SelectedPath;
                var regex = new Regex(@"\s");

                if (String.IsNullOrEmpty(folder))
                {
                    MessageBox.Show("You can not add nothing");
                }
                else
                {
                    if (regex.IsMatch(folder))
                    {
                        string short_path = folder.Remove(0, 1);
                        source_rtb.Text += short_path + "\n";
                        folderlist.Add(short_path);
                    }
                    else
                    {
                        source_rtb.Text += folder + "\n";
                        folderlist.Add(folder);
                    }
                }
            }
        }
    }
}