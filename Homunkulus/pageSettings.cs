using DocumentFormat.OpenXml.Presentation;
using Newtonsoft.Json.Linq;

namespace Homunkulus
{
    public partial class pageSettings : Form
    {
        public pageSettings()
        {
            InitializeComponent();
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
