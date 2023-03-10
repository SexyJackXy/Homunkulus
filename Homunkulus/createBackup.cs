using System.Diagnostics;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using ClosedXML.Excel;
using System.Xml;
using System.IO;

namespace Homunkulus
{
    public partial class createBackup : Form
    {
        List<string> folderlist = new List<string>();

        public createBackup()
        {
            InitializeComponent();
        }
        private void Overview_Load(object sender, EventArgs e)
        {
            source_rtb.Text = savedBackups.backupPlan;
            Destination_txt.Text = savedBackups.backupPlanDest;
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
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
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
        public void Settings (bool comrpess, bool compliemntray)
        {
            if (check_compress.Checked)
            {
                comrpess = true;
            }
            else
            {
                comrpess = false;
            }

            if (check_compress.Checked)
            {
                comrpess = true;
            }
            else
            {
                comrpess = false;
            }
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
                if (regex.IsMatch(folder))
                {
                    string short_path = folder.Remove(0, 1);
                    source_rtb.Text += short_path + "\n";
                    source_rtb.SelectAll();
                    source_rtb.SelectionAlignment = HorizontalAlignment.Left;
                    source_rtb.DeselectAll();
                    folderlist.Add(short_path);
                }
                else
                {
                    source_rtb.Text += folder + "\n";
                    source_rtb.SelectAll();
                    source_rtb.SelectionAlignment = HorizontalAlignment.Left;
                    source_rtb.DeselectAll();
                    folderlist.Add(folder);
                }
            }
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();  
            stopwatch.Start();

            DateTime datetime = DateTime.Today;

            string logPath = @"Resources\logs";
            string elapsedTime;
            string destpath = Destination_txt.Text;
            string date = datetime.ToString("dd/MM/yyyy");
            string dest = destpath + "Backup "+ date;
            string path = logPath + @"\" + date + ".txt";
            string shrt;
            int rtbLines = folderlist.Count();
            StreamWriter sw = new StreamWriter(path);

            try
            {
                Directory.CreateDirectory(dest);
            }
            catch
            {
                DialogResult dr = MessageBox.Show("Do you want to select a oter Path to save your Backup", "ERROR 404", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();

                    if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        destpath = fbd.SelectedPath;
                        dest = destpath + @"\Backup " + date;
                        MessageBox.Show(dest);
                        Directory.CreateDirectory(dest);
                    }
                }
                if (dr == DialogResult.No)
                {
                    this.Close();
                }
            }

            for(int i = 0; i <= rtbLines; i++)
            {
                string sourceDirectory = folderlist.ElementAt(i);
                folderlist.Add(sourceDirectory);
            }

            if (folderlist.Count > 0)
            {
                for(int i = 0; i < folderlist.Count; i++)
                {
                    string sourceDirectory = folderlist.ElementAt(i);
                    shrt = sourceDirectory.Substring(sourceDirectory.LastIndexOf("\\") + 1);
                    string subfolder = destpath + "/Backup " + date + "/" + shrt;
                    string targetDirectory = subfolder;

                    if (Directory.Exists(sourceDirectory))
                    {
                        Directory.CreateDirectory(subfolder);
                        Copy(sourceDirectory, targetDirectory);
                    }
                }
            }

            stopwatch.Stop();                       
            TimeSpan ts = stopwatch.Elapsed;        
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds / 10);


            sw.WriteLine(datetime.ToString(" dd/MM/yyyy" + "|" + "HH:mm"));
            sw.WriteLine(datetime.ToString(elapsedTime));

            source_rtb.Clear();
            source_rtb.Text = "Finished Sucessfull";
        }
        private void add_data_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string Fullpath = ofd.FileName;
                string Filename = ofd.SafeFileName;
                string folder = Fullpath.Replace(Filename, "");

                if (String.IsNullOrEmpty(folder))
                {
                    MessageBox.Show("You can not add nothing");
                }
                else
                {
                    source_rtb.Text += folder;
                }
            }
        }
        private void dest_folder_btn_Click(object sender, EventArgs e)
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
                        Destination_txt.Text = folder + @"\";
                    }
                    else
                    {
                        Destination_txt.Text = folder + @"\";
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Today;
            string date = datetime.ToString("dd/MM/yyyy");
            string path = (@"Resources\backupplans\Backup_" + date + ".txt");
            string soruce = source_rtb.Text;
            string destination = Destination_txt.Text;

            File.WriteAllText(path, "Destination" + "\n" + destination + "\n" + "\n"); // Bug
            File.AppendAllText(path, "Source" + "\n" + soruce);
            MessageBox.Show("Saved");

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
        private void clear_btn_Click(object sender, EventArgs e)
        {
            Destination_txt.Text = string.Empty;
            source_rtb.Text = string.Empty;
        }
        private void import_backup_btn_Click(object sender, EventArgs e)
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