using DocumentFormat.OpenXml.Presentation;
using Homunkulus.helper;
using Newtonsoft.Json;
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
            public string fileExtension { get; set; }
        }

        private void pageSettings_Load(object sender, EventArgs e)
        {

            var savePath = @"../../../config";
            var directoryInfo = new DirectoryInfo(savePath);
            var firstFilePath = directoryInfo.GetFiles().OrderByDescending(x => x.LastWriteTime).FirstOrDefault();
            var jsonFileContent = System.Text.Json.JsonSerializer.Deserialize<config[]>(File.ReadAllText(firstFilePath.FullName));

            var fileExt = jsonFileContent.Select(x => x.fileExtension).FirstOrDefault();

            if (fileExt != null) 
            {
                fileExtDropDown.Text = fileExt;
            }
        }


        private void saveSettings_btn_Click(object sender, EventArgs e)
        {
            var guid = Guid.NewGuid().ToString();
            var savePath = @"../../../config/config_" + guid + ".json ";
            var fileExtension = fileExtDropDown.Text;

            JObject binData = new JObject(
                new JProperty("fileExtension", fileExtension)
                );

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
