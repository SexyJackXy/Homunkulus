using System.Text.RegularExpressions;
using Homunkulus.Helper;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Homunkulus
{
    public partial class pageBackupConfiguration : Form
    {
        List<string> sourceFolderList = new List<string>();
        List<string> fileList = new List<string>();
        List<string> destsourceFolderList = new List<string>();
        List<string> newFoldersList = new List<string>();
        Util util = new Util();

        public pageBackupConfiguration()
        {
            InitializeComponent();
        }
        private void Overview_Load(object sender, EventArgs e)
        {
            source_rtb.Text = savedBackups.backupPlan;
            Destination_txt.Text = savedBackups.backupPlanDest;

            var Compress = savedBackups.compressedBackup;
            var Compliemntray = savedBackups.incrementalBackup;

            if (Compress == true)
            {
                check_compress.Checked = true;
            }
            if (Compliemntray == true)
            {
                check_incremental.Checked = true;
            }
        }

        //Button Methoden
        //Here the start button is clicked and the backup is started
        private void start_btn_Click(object sender, EventArgs e)
        {
            var test = @"..\..\..\;ogs";
            var linesInRtb = source_rtb.Lines.Count();
            var destinationFolder = Destination_txt.Text;
            var destinationZip = destinationFolder + ".zip";
            var backupConfigurationHelper = new pageBackupConfigurationHelper();

            if (sourceFolderList.Count == 0)
            {
                for (var i = 0; i < linesInRtb; i++)
                {
                    sourceFolderList.Add(source_rtb.Lines[i]);
                }
            }

            if (check_incremental.Checked)
            {
                backupConfigurationHelper.CopyIncrementalBackup(destinationFolder, sourceFolderList);
            }

            if (check_compress.Checked)
            {
                backupConfigurationHelper.CopyCompressedBackup(destinationFolder, sourceFolderList);
            }

            if (!check_compress.Checked && !check_incremental.Checked)
            {
                backupConfigurationHelper.CopyFullBackup(sourceFolderList, Destination_txt);
            }

            source_rtb.Text = "Backup has been completed successfully";
        }
        private void src_btn_Click(object sender, EventArgs e)
        {
            using var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Multiselect = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var folders = dialog.FileNames;
                if (folders == null)
                {
                    MessageBox.Show("You can't add nothing");
                }
                else
                {
                    source_rtb.Text = string.Join("\n", folders);
                }
            }
        }
        private void add_data_btn_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            using var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Multiselect = true
            };

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var Fullpath = ofd.FileName;
                var Filename = ofd.SafeFileName;
                var folder = Fullpath.Replace(Filename, "");

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
            var fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var folder = fbd.SelectedPath.stringClean();
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
            var backupplan = new pageBackupConfigurationHelper();
            var compress = check_compress.Checked ? true : false;
            var incremental = check_incremental.Checked ? true : false;
            var soruce = source_rtb.Text;
            var destination = Destination_txt.Text;

            backupplan.CreatePlan(compress, incremental, soruce, destination);
        }

        //Navigation Methoden
        private void create_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            new pageBackupConfiguration().ShowDialog();
            this.Close();
        }
        private void home_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            new pageHomeSite().ShowDialog();
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
    }
}