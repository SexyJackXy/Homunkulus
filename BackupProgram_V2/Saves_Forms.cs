using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BackupProgram_V2
{
    public partial class Saves_Forms : Form
    {
        public Saves_Forms()
        {
            InitializeComponent();
        }

        public void PopulateTree(string dir, TreeNode node)
        {
            DirectoryInfo directory = new DirectoryInfo(dir);

            foreach(DirectoryInfo d in directory.GetDirectories())
            {
                TreeNode t = new TreeNode(d.Name);
                if (node != null) node.Nodes.Add(t);
                else treeView2.Nodes.Add(t);
                PopulateTree(d.FullName, t);
            }
            foreach(FileInfo f in directory.GetFiles())
                {
                TreeNode t = new TreeNode(f.Name);
                if (node != null) node.Nodes.Add(t);
                else treeView2.Nodes.Add(t);
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Forms f1 = new Home_Forms();
            f1.ShowDialog();
            this.Close();
        }

        private void his_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            History_Forms f2 = new History_Forms();
            f2.ShowDialog();
            this.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Saves_Load(object sender, EventArgs e)
        {
            PopulateTree(@"saves", null);
        }

        private void reload_btn_Click(object sender, EventArgs e)
        {
            treeView2.Nodes.Clear();
            PopulateTree(@"saves", null);
            richTextBox3.Clear();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView2.SelectedNode;
            if(node != null)
            {
                try
                {
                    string SelectedNode = node.Text;
                    string Path = @"saves\settings\" + SelectedNode;
                    string Content = File.ReadAllText(Path);
                    richTextBox3.Text = SelectedNode + " Wird geöffnet" + "\n";
                    richTextBox3.Text = Content;
                }
                catch
                {
                    MessageBox.Show("Ups");
                }         
            }
        }

        private void Load_File_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select A File";
            openDialog.Filter = "Text Files (*.txt)|*.txt" + "|" +
                                "All Files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openDialog.FileName;
                string content = File.ReadAllText(file);
                richTextBox3.Text = content;
            }
        }
    }
}
