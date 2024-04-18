namespace Homunkulus
{
    public partial class loadBackup : Form
    {
        public loadBackup()
        {
            InitializeComponent();
        }

        public string fileName;

        private void import_backup_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var sourceFile = ofd.FileName;
                fileName = ofd.SafeFileName;

                path_tbx.Text = sourceFile;

                StreamReader sr = new StreamReader(sourceFile);

                var content = sr.ReadToEnd();
                Content_rtb.Text = content;
            }

        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Today;
            var date = datetime.ToString("dd/MM/yyyy");
            var source = path_tbx.Text;
            var destination = @"Resources\backupplans\Backup_" + date + ".config";

            if (source.Length == 0)
            {
                MessageBox.Show(" You need to Import a File at first");
            }
            else
            {
                File.Copy(source, destination);
            }
        }
        private void create_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            createBackup ov = new createBackup();
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
        private void restore_pbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            loadBackup bps = new loadBackup();
            bps.ShowDialog();
            this.Close();
        }
        private void plans_pbox_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            savedBackups hs = new savedBackups();
            hs.ShowDialog();
            this.Close();
        }
        private void create_pbox_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            createBackup ov = new createBackup();
            ov.ShowDialog();
            this.Close();
        }
        private void home_pbox_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Landingpage lp = new Landingpage();
            lp.ShowDialog();
            this.Close();
        }
    }
}
