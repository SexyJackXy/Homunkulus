using Homunkulus.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static Homunkulus.pageSettings;

namespace Homunkulus
{
    public partial class pageSettings : Form
    {
        private Util util = new Util();
        public string configPath =  @"../../../config/configuratio.json ";
        public pageSettings()
        {
            InitializeComponent();
        }

        public class config
        {
            [JsonProperty("Extension")]
            public string? fileExtension { get; set; }
        }

        private void pageSettings_Load(object sender, EventArgs e)
        {
            savedLable.Visible = false;

            if (!File.Exists(configPath))
            {
                File.Create(configPath);
            }

            var jsonContent = File.ReadAllText(configPath);
            if (!String.IsNullOrEmpty(jsonContent))
            {
                config config = JsonConvert.DeserializeObject<config>(jsonContent);

                file_save_cb.Text = config.fileExtension;
            }
        }

        private void saveSettings_btn_Click(object sender, EventArgs e)
        {
            var guid = Guid.NewGuid().ToString();

            var configValues = new JObject()
            {
                new JProperty("Extension",file_save_cb.Text)
            };

            File.WriteAllText(configPath, configValues.ToString());

            savedLable.Visible = true;
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
