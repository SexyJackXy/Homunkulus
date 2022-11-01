using System.Diagnostics;

namespace Homunkulus
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void create_backup_btn_Click(object sender, EventArgs e)
        {

        }

        private void import_backup_btn_Click(object sender, EventArgs e)
        {

        }

        private void src_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();


        }
    }
}