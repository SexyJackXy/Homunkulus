using Homunkulus.Helper;
using Newtonsoft.Json.Linq;

namespace Homunkulus
{
    public partial class pageSettings : Form
    {
        private Util util = new Util();

        public pageSettings()
        {
            InitializeComponent();
        }

        public class config
        {
            public string? fileExtension { get; set; }
            public string? startMips { get; set; }
        }
        private void pageSettings_Load(object sender, EventArgs e)
        {
            var savePath = util.mainDirectory + "config";
            var directoryInfo = new DirectoryInfo(savePath);
            var firstFile = directoryInfo.GetFiles().OrderByDescending(x => x.LastWriteTime).FirstOrDefault();
            var jsonContent = File.ReadAllText(firstFile.FullName);
            var configArray = System.Text.Json.JsonSerializer.Deserialize<config>(jsonContent);

            file_save_cb.Text = configArray.fileExtension;
            start_mips_cb.Text = configArray.startMips;
        }

        private void saveSettings_btn_Click(object sender, EventArgs e)
        {
            var guid = Guid.NewGuid().ToString();
            var savePath = util.mainDirectory + "config/config_" + guid + ".json ";

            var configValues = new JObject()
            {
                new JProperty("Extension",file_save_cb.Text),
                new JProperty("M.I.P.S",start_mips_cb.Text)
            };

            File.WriteAllText(savePath, configValues.ToString());
        }

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
    }
}
