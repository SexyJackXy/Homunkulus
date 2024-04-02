using System.Text.RegularExpressions;

namespace Homunkulus
{
    public partial class createBackup : Form
    {
        List<string> folderlist = new List<string>();
        List<string> destFolderList = new List<string>();
        List<string> newFoldersList = new List<string>();
        public createBackup()
        {
            InitializeComponent();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            source_rtb.Text = savedBackups.backupPlan;
            Destination_txt.Text = savedBackups.backupPlanDest;

            var Compress = savedBackups.booCompress;
            var Compliemntray = savedBackups.booCompliemntray;

            if (Compress == true)
            {
                check_compress.Checked = true;
            }
            if (Compliemntray == true)
            {
                check_complimentary.Checked = true;
            }
        }
        public void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }
        public void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
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
        public void copyFromList(List<string> pathList)
        {
            DateTime datetime = DateTime.Today;

            var shrt = "";
            var sourceDirectory = "";
            var targetDirectory = "";
            var destFolder = Destination_txt.Text;
            var date = datetime.ToString("dd/MM/yyyy");
            var newBackupFolder = destFolder + "Backup " + date;

            for (var i = 0; i < folderlist.Count; i++)
            {
                sourceDirectory = folderlist.ElementAt(i);
                shrt = sourceDirectory.Substring(sourceDirectory.LastIndexOf("\\") + 1);
                targetDirectory = destFolder + "/Backup " + date + "/" + shrt;

                if (Directory.Exists(newBackupFolder))
                {
                    Copy(sourceDirectory, targetDirectory);
                }
                else
                {
                    Directory.CreateDirectory(newBackupFolder);
                    Copy(sourceDirectory, targetDirectory);
                }
            }
        }

        //Button Methoden
        private void start_btn_Click(object sender, EventArgs e)
        {
            var caseNumber = 0;

            var rtbLines = source_rtb.Lines.Count();
            var rtbToList = source_rtb;

            if (check_complimentary.Checked) { caseNumber++; }
            if (check_compress.Checked) { caseNumber++; }


            switch (caseNumber)
            {
                case 0:
                    if (folderlist.Count > 0)
                    {
                        copyFromList(folderlist);
                    }
                    else
                    {
                        for (var i = 0; i < rtbLines; i++)
                        {
                            string rtbCurrentLine = source_rtb.Lines[i];
                            folderlist.Add(rtbCurrentLine);
                        }

                        copyFromList(folderlist);
                    }
                    break;
                case 1:
                    if (check_complimentary.Checked)
                    {
                        //Here comes the Complimentray method
                    }
                    if (check_compress.Checked)
                    {
                        //Here comes the Compressed method
                    }
                    break;
                case 2:
                    //Here comes the Compressed and Complimentray method  
                    break;
            }
        }
        private void src_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var folder = fbd.SelectedPath;
                var regex = new Regex(@"\s");
                var lineCount = source_rtb.Lines.Count();

                if (String.IsNullOrEmpty(folder))
                {
                    MessageBox.Show("You can not add nothing");
                }
                source_rtb.AppendText(Environment.NewLine + folder);
                folderlist.Add(folder);
            }
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
                    MessageBox.Show(folder);
                    source_rtb.Text += folder;
                }
            }
        }
        private void dest_folder_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var folder = fbd.SelectedPath;
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
        private void save_btn_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Today;

            bool compress = check_compress.Checked ? true : false;
            bool compliemntray = check_complimentary.Checked ? true : false;
            string strCompress = Convert.ToString(compress);
            string strCompliemntray = Convert.ToString(compliemntray);
            string date = datetime.ToString("dd/MM/yyyy");
            string path = (@"Resources\backupplans\Backup_" + date + ".txt");
            string soruce = source_rtb.Text;
            string destination = Destination_txt.Text;

            File.WriteAllText(path, "Destination" + "\n" + destination + "\n");
            File.AppendAllText(path, "Source" + "\n" + soruce + "\n" + "\n");
            File.AppendAllText(path, "Compress " + strCompress + "\n");
            File.AppendAllText(path, "Compliemntray " + strCompliemntray + "\n");
            MessageBox.Show("Saved");
        }

        //Navigation Methoden
        private void create_pbox_Click(object sender, EventArgs e)
        {
            new createBackup().ShowDialog();
            this.Close();
        }
        private void home_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Landingpage().ShowDialog();
            this.Close();
        }
        private void plans_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            new savedBackups().ShowDialog();
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
            new savedBackups().ShowDialog();
            this.Close();
        }
        private void restore_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loadBackup().ShowDialog();
            this.Close();
        }
        private void multifolder_select_btn_Click(object sender, EventArgs e)
        {
            new multiFolderSelect().ShowDialog();
        }
    }
}