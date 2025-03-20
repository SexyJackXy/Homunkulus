using Newtonsoft.Json.Linq;

namespace Homunkulus
{
    public partial class pageSettings : Form
    {
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
            var savePath = @"../../../config";
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
            var savePath = @"../../../config/config_" + guid + ".json ";
            var fileExtension = file_save_cb.Text;
            var startMips = start_mips_cb.Text;

            var binData = new JObject()
            {
                new JArray
                {
                    {
                        new JObject()
                        {
                            { "fileExtension", fileExtension },
                            { "startMips", startMips }
                        }
                    }
                }
            };

            File.WriteAllText(savePath, binData.ToString());
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
