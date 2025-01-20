using Homunkulus.Helper;
using System;
using System.Diagnostics;

namespace Homunkulus
{
    public partial class savedBackups : Form
    {
        public static string? backupPlan = " ";
        public static string? backupPlanDest = " ";
        public static bool booCompress = false;
        public static bool booCompliemntray = false;
        private List<string> cache = new List<string>();
        private string path = @"..\..\..\backupplans\";
        private string editedNode = string.Empty;
        private string tmpFile = string.Empty;

        public savedBackups()
        {
            InitializeComponent();
        }

        public void PopulateTree(string dir, TreeNode? node)
        {
            DirectoryInfo directory = new DirectoryInfo(dir);
            var files = directory.GetFiles();
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
            //TODO: Make it possible to load XML Files
            
            TreeNode node = treeView2.SelectedNode;
            StreamReader? sr;
            var destination = "";

            var selectedNode = node.Text;
            var seltedDataPath = path + selectedNode;
            var source = new List<string>();
            sr = new StreamReader(seltedDataPath);
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
                    booCompress = true;
                }
                else if (currentLine.Contains("Compress False"))
                {
                    booCompress = false;
                }
                else if (currentLine.Contains("Compliemntray True"))
                {
                    booCompliemntray = true;
                }
                else if (currentLine.Contains("Compliemntray False"))
                {
                    booCompliemntray = false;
                }
                else
                {
                    source.Add(currentLine);
                }
            }

            backupPlanDest = destination;
            backupPlan = string.Join("\n", source);

            this.Hide();
            pageBackupConfiguration ov = new pageBackupConfiguration();
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
            TreeNode node = treeView2.SelectedNode;
            var guid = Guid.NewGuid().ToString();

            if (node != null)
            {
                editedNode = node.Text;
                var nodePath = path + node.Text;

                var tmpPath = Path.Combine(@"..\..\..\tmp-in\", guid + ".xml");
                File.Copy(nodePath, tmpPath);

                if (File.Exists(tmpPath))
                {
                    StreamReader sr = new StreamReader(nodePath);
                    var content = sr.ReadToEnd();

                    treeView2.Visible = false;

                    folderName_tbox.Visible = true;
                    edit_rtb.Visible = true;
                    save_Changes_btn.Visible = true;
                    label1.Visible = true;

                    folderName_tbox.Text = node.Text;
                    edit_rtb.Text = content;
                }
                else
                {
                    MessageBox.Show("The selected file does not exist.");
                }
            }
            else
            {
                MessageBox.Show("You need to select a file.");
            }
        }
        private void save_Changes_btn_Click(object sender, EventArgs e)
        {
            var editedContent = edit_rtb.Text;
            var savePath = path + editedNode;
            var folderName = folderName_tbox.Text;

            if (folderName != editedNode)
            {
                savePath = path + folderName;
                File.WriteAllText(savePath, editedContent);

                MessageBox.Show("Succefully Saved");
            }
        }
        private void open_backups_btn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", path);
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            folderName_tbox.Visible = false;
            edit_rtb.Visible = false;
            treeView2.Visible = true;

            treeView2.Nodes.Clear();
            PopulateTree(path, null);

            if (!tmpFile.IsNullOrEmpty())
            {
                File.Delete(tmpFile);
            }
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TreeNode node = treeView2.SelectedNode;
                var deletePath = path + node.Text;

                File.Delete(deletePath);
                MessageBox.Show("Deleted");

                PopulateTree(path, null);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void History_Load(object sender, EventArgs e)
        {
            PopulateTree(path, null);
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
            savedBackups hs = new savedBackups();
            hs.ShowDialog();
            this.Close();
        }
    }
}
