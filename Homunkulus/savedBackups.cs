using System.Diagnostics;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Homunkulus
{
    public partial class savedBackups : Form
    {
        public static string backupPlan = " ";
        public static string backupPlanDest = " ";
        public static bool booCompress = false;
        public static bool booCompliemntray = false;

        public savedBackups()
        {
            InitializeComponent();
        }

        List<string> cache = new List<string>();

        string path = @"Resources\backupplans\";
        string editedNode = "";

        public void PopulateTree(string dir, TreeNode? node)
        {
            DirectoryInfo directory = new DirectoryInfo(dir);

            foreach (DirectoryInfo d in directory.GetDirectories())
            {
                TreeNode t = new TreeNode(d.Name);
                if (node != null) node.Nodes.Add(t);
                else treeView2.Nodes.Add(t);
                PopulateTree(d.FullName, t);
            }
            foreach (FileInfo f in directory.GetFiles())
            {
                TreeNode t = new TreeNode(f.Name);
                if (node != null) node.Nodes.Add(t);
                else treeView2.Nodes.Add(t);
            }
        }
        private void Load_btn_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView2.SelectedNode;

            var destination = string.Empty;

            var selectedNode = node.Text;
            var seltedDataPath = path + selectedNode;

            var source = new List<string>();

            StreamReader sr = new StreamReader(seltedDataPath);

            var lineCout = File.ReadAllLines(seltedDataPath).Length;
            var stopAtLine = lineCout - 5;

            for (var i = 0; i < 3; i++)
            {
                if (sr.ReadLine().Contains("Source"))
                {
                    break;
                }

                destination = sr.ReadLine();
            }

            for (var i = 0; i <= stopAtLine; i++)
            {
                var currentLine = sr.ReadLine();
                if (currentLine == null) break;
                if (currentLine.Contains("Compress True"))
                {
                    var rightStatus = currentLine.Substring(currentLine.IndexOf(" ") + 1);
                    booCompress = true;
                }
                else if (currentLine.Contains("Compliemntray True"))
                {
                    var rightStatus = currentLine.Substring(currentLine.IndexOf(" ") + 1); ;
                    booCompliemntray = true;
                }
                else
                {
                    source.Add(currentLine);
                }
            }

            source.RemoveAt(0);

            backupPlanDest = destination;
            backupPlan = string.Join("\n", source);

            this.Hide();
            createBackup ov = new createBackup();
            ov.ShowDialog();
            this.Close();
        }
        private void Open_btn_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = treeView2.SelectedNode;

                var selectedNode = node.Text;
                var nodePath = path + selectedNode;
                string[] content = File.ReadAllLines(nodePath);

                cache.Add(nodePath);

                treeView2.Nodes.Clear();

                foreach (var line in content)
                {
                    treeView2.Nodes.Add(line);
                }
            }
            catch
            {
                MessageBox.Show("Sie haben keine Datein ausgewählt");
            }
        }
        private void Edit_btn_Click(object sender, EventArgs e)
        {
            //öffnet entweder ein dialog zum Ordner editren oder öffnenen pfad wo die datei Liegt
            TreeNode node = treeView2.SelectedNode;
            if(node !=  null)
            {
                editedNode = node.Text;
                var nodePath = path + node.Text;

                StreamReader sr = new StreamReader(nodePath);
                var content = sr.ReadToEndAsync();

                edit_rtb.Visible = true;
                save_Changes_btn.Visible = true;
                label1.Visible = true;
                treeView2.Visible = false;

                edit_rtb.Text = content.Result;
            }

            

        }

        private void open_backups_btn_Click(object sender, EventArgs e)
        {
            Process.Start(@"runtimes\win\");
        }

        private void save_Changes_btn_Click(object sender, EventArgs e)
        {
            var editedContent = edit_rtb.Text;
            var savePath = path + editedNode;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            edit_rtb.Visible = false;
            treeView2.Visible = true;

            treeView2.Nodes.Clear();
            PopulateTree(path, null);
        }
        private void History_Load(object sender, EventArgs e)
        {
            PopulateTree(path, null);
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
    }
}
