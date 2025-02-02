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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
