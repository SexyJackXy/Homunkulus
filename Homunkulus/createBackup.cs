using System.IO.Compression;
using System.Text.RegularExpressions;

namespace Homunkulus
{
    public partial class createBackup : Form
    {
        List<string> sourceFolderList = new List<string>();
        List<string> fileList = new List<string>();
        List<string> destsourceFolderList = new List<string>();
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
                check_incremental.Checked = true;
            }
        }
        public void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            copyAll(diSource, diTarget);
        }
        public void copyAll(DirectoryInfo source, DirectoryInfo target)
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
                    DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                    copyAll(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch
            {
                //Do Something
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

            for (var i = 0; i < pathList.Count; i++)
            {
                sourceDirectory = sourceFolderList.ElementAt(i);
                shrt = sourceDirectory.Substring(sourceDirectory.LastIndexOf("\\") + 1);
                targetDirectory = destFolder + "/Backup " + date + "/" + shrt;

                var attributs = File.GetAttributes(sourceDirectory);

                if ((attributs & FileAttributes.Directory) != FileAttributes.Directory)
                {
                    try
                    {
                        File.Copy(sourceDirectory, targetDirectory);
                    }
                    catch
                    {
                        //skip this File
                    }
                }
                else if (Directory.Exists(newBackupFolder) && !String.IsNullOrEmpty(sourceDirectory))
                {
                    Copy(sourceDirectory, targetDirectory);
                }
                else if (!String.IsNullOrEmpty(sourceDirectory))
                {
                    Directory.CreateDirectory(newBackupFolder);
                    Copy(sourceDirectory, targetDirectory);
                }
                else
                {
                    break;
                }
            }
        }
        public void copyFilesFromList(List<string> fileList, string destinationPath)
        {
            var documentsPath = @"C:\Users\Tim\Documents\";
            var userRootPath = @"C:\Users\Tim\";
            var backupFolderName = "Backup " + DateTime.Now.ToString("dd.MM.yyyy");
            var finalDestinationPath = Path.Combine(destinationPath, backupFolderName);

            foreach (var file in fileList)
            {
                var fi = new FileInfo(file);
                var fileName = fi.Name;
                var sourceDirPath = fi.DirectoryName;
                var relativeDirPath = sourceDirPath;


                if (relativeDirPath.StartsWith(@"\") || relativeDirPath.StartsWith("/"))
                {
                    relativeDirPath = relativeDirPath.Substring(1);
                }

                var targetDirPath = Path.Combine(finalDestinationPath, relativeDirPath);
                if (!Directory.Exists(targetDirPath))
                {
                    Directory.CreateDirectory(targetDirPath);
                }

                var targetFilePath = Path.Combine(targetDirPath, fileName);
                try
                {
                    File.Copy(sourceDirPath, targetFilePath);
                }
                catch { }

            }
        }
        public void incrementalCopy(string destinationPath, List<string> sourceList)
        {
            var tfs = new TemporaryFileStore(destinationPath);
            var complimentaryFiles = new List<string>();

            for (var i = 0; i < sourceList.Count; i++)
            {
                if (sourceList[i] != "")
                {
                    var sourcePath = sourceList.ElementAt(i).Trim();
                    var sourcePathFiles = Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories);
                    var existingFiles = tfs.Files.Where(x => x.Contains(sourcePath.Substring(3))).ToList();

                    var sourcePathFilesShort = sourcePathFiles.Select(file => file.Length > 29 ? file.Substring(3) : file).ToList();
                    var existingFilesShort = existingFiles.Select(file => file.Length > 29 ? file.Substring(28) : file).ToList();

                    var gemeinsameElemente = sourcePathFilesShort.Intersect(existingFilesShort).ToList();

                    sourcePathFilesShort = sourcePathFilesShort.Except(gemeinsameElemente).ToList();
                    existingFilesShort = existingFilesShort.Except(gemeinsameElemente).ToList();

                    var filesToCopy = sourcePathFilesShort.Concat(existingFilesShort).ToList();
                    copyFilesFromList(filesToCopy, destinationPath);
                }
            }
        }

        //Button Methoden
        private void start_btn_Click(object sender, EventArgs e)
        {
            var linesInRtb = source_rtb.Lines.Count();
            var destinationFolder = Destination_txt.Text;
            var destinationZip = destinationFolder + ".zip";

            if (sourceFolderList.Count == 0)
            {
                for (var i = 0; i < linesInRtb; i++)
                {
                    sourceFolderList.Add(source_rtb.Lines[i]);
                }
            }

            if (check_incremental.Checked)
            {
                incrementalCopy(destinationFolder, sourceFolderList);
            }

            if (check_compress.Checked)
            {
                try
                {
                    copyFromList(sourceFolderList);

                    ZipFile.CreateFromDirectory(destinationFolder, destinationZip, CompressionLevel.SmallestSize, true);

                    if (Directory.Exists(destinationFolder))
                    {
                        Directory.Delete(destinationFolder);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went Wrong");
                }
            }

            if (!check_compress.Checked && !check_incremental.Checked)
            {
                copyFromList(sourceFolderList);
            }

            source_rtb.Text = "Backup has been completed successfully";
        }
        private void src_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var folder = fbd.SelectedPath;

                if (String.IsNullOrEmpty(folder))
                {
                    MessageBox.Show("You can not add nothing");
                }
                source_rtb.AppendText(Environment.NewLine + folder);
                sourceFolderList.Add(folder);
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
            bool compliemntray = check_incremental.Checked ? true : false;
            string strCompress = Convert.ToString(compress);
            string strCompliemntray = Convert.ToString(compliemntray);
            string date = datetime.ToString("dd/MM/yyyy");
            string path = (@"..\..\..\backupplans\Backup_" + date + ".txt");
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
            this.Hide();
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