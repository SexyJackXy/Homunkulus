using Homunkulus.Helper;

namespace Homunkulus
{
    public partial class pageHomeSite : Form
    {
        private Util util = new Util();
        public pageHomeSite()
        {
            InitializeComponent();
        }

        private void Landingpage_Load(object sender, EventArgs e)
        {
            var backupPath = @"..\..\..\backupplans";
            var logPath = @"..\..\..\logs";

            util.createDirIfNotExsits(backupPath);
            util.createDirIfNotExsits(logPath);

            System.IO.DirectoryInfo planDir = new System.IO.DirectoryInfo(backupPath);
            var count = planDir.GetFiles().Length;
            numb_backup.Text = Convert.ToString(count);

            System.IO.DirectoryInfo runDir = new System.IO.DirectoryInfo(logPath);
            var runCount = runDir.GetFiles().Length;
            numb_execute.Text = Convert.ToString(runCount);
        }
        private void create_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            pageBackupConfiguration ov = new pageBackupConfiguration();
            ov.ShowDialog();
            this.Close();
        }
        private void show_backup_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            savedBackups his = new savedBackups();
            his.ShowDialog();
            this.Close();
        }
        private void create_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            pageBackupConfiguration ov = new pageBackupConfiguration();
            ov.ShowDialog();
            this.Close();
        }
        private void home_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            pageHomeSite lp = new pageHomeSite();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pageSettings ps = new pageSettings();
            ps.ShowDialog();
            this.Close();
        }
    }
}
