using System.Text.RegularExpressions;
using Homunkulus.Helper;

namespace Homunkulus
{
    public partial class createBackup : Form
    {
        List<string> sourceFolderList = new List<string>();
        List<string> fileList = new List<string>();
        List<string> destsourceFolderList = new List<string>();
        List<string> newFoldersList = new List<string>();
        Util util = new Util();

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

        //Button Methoden
        //Here the start button is clicked and the backup is started
        private void start_btn_Click(object sender, EventArgs e)
        {
            var linesInRtb = source_rtb.Lines.Count();
            var destinationFolder = Destination_txt.Text;
            var destinationZip = destinationFolder + ".zip";
            var copy = new Clone();

            if (sourceFolderList.Count == 0)
            {
                for (var i = 0; i < linesInRtb; i++)
                {
                    sourceFolderList.Add(source_rtb.Lines[i]);
                }
            }

            if (check_incremental.Checked)
            {
                copy.Incremental(destinationFolder, sourceFolderList);
            }

            if (check_compress.Checked)
            {
                throw new NotImplementedException();
            }

            if (!check_compress.Checked && !check_incremental.Checked)
            {
                copy.FromList(sourceFolderList, Destination_txt);
            }

            source_rtb.Text = "Backup has been completed successfully";
        }
        private void src_btn_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var folder = fbd.SelectedPath.stringClean();

                if (String.IsNullOrEmpty(folder))
                {
                    MessageBox.Show("You can not add nothing");
                }
                if (source_rtb.Text.Length == 1)
                {
                    source_rtb.Clear();
                    source_rtb.AppendText(folder);
                }
                else
                {
                    source_rtb.AppendText("\n" + folder);
                }
                sourceFolderList.Add(folder);
            }
        }
        private void add_data_btn_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

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
            var util = new Util();
            bool compress = check_compress.Checked ? true : false;
            bool compliemntray = check_incremental.Checked ? true : false;
            string soruce = source_rtb.Text;
            string destination = Destination_txt.Text;

            util.createBackupPlan(compress, compliemntray, soruce, destination);
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
    }
}