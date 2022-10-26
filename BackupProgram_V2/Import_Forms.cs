using System;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Vml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;

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

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(System.IO.Path.Combine(target.FullName, fi.Name), true);
            }
            try
            {
                // Copy each subdirectory using recursion.
                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir =
                        target.CreateSubdirectory(diSourceSubDir.Name);
                    CopyAll(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch
            {

            }
        }

        private void import_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();

            if (fdb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox2.Text = fdb.SelectedPath;

                string sourceDirectory = fdb.SelectedPath;
                string targetDirectory = @"C:\Users\Tim\Documents";


                if (Directory.Exists(sourceDirectory))
                {
                    Copy(sourceDirectory, targetDirectory);
                }
            }
        }
    }
}
