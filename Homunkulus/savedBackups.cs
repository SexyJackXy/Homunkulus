using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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

        string path = @"Resources\backupplans";

        public void PopulateTree(string dir, TreeNode node)
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


            var seltedDataPath = string.Empty;
            var destination = string.Empty;

            var selectedNode = node.Text;
            seltedDataPath = @"Resources\backupplans\" + selectedNode;

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

            source.RemoveAt(source.Count - 1);

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
                var path = @"Resources\backupplans\" + selectedNode;
                string[] content = File.ReadAllLines(path);

                cache.Add(path);

                treeView2.Nodes.Clear();

                foreach (var line in content)
                {
                    treeView2.Nodes.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sie haben keine Datein ausgewählt");
            } 
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
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
