namespace Homunkulus
{
    public partial class pageHomeSite : Form
    {
        public pageHomeSite()
        {
            InitializeComponent();
        }

        private void Landingpage_Load(object sender, EventArgs e)
        {
            var path = @"..\..\..\backupplans";
            var runPath = @"..\..\..\logs";
            var test = this.Text;

            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
            var count = dir.GetFiles().Length;
            numb_backup.Text = Convert.ToString(count);

            System.IO.DirectoryInfo dir2 = new System.IO.DirectoryInfo(runPath);
            var runCount = dir2.GetFiles().Length;
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
            pagePlanManagement his = new pagePlanManagement();
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
            pagePlanManagement hs = new pagePlanManagement();
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
