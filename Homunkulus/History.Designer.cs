namespace Homunkulus
{
    partial class History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.panel1 = new System.Windows.Forms.Panel();
            this.restore_pbox = new System.Windows.Forms.PictureBox();
            this.create_pbox = new System.Windows.Forms.PictureBox();
            this.plans_pbox = new System.Windows.Forms.PictureBox();
            this.home_pbox = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restore_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plans_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.restore_pbox);
            this.panel1.Controls.Add(this.create_pbox);
            this.panel1.Controls.Add(this.plans_pbox);
            this.panel1.Controls.Add(this.home_pbox);
            this.panel1.Location = new System.Drawing.Point(0, 609);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 40);
            this.panel1.TabIndex = 4;
            // 
            // restore_pbox
            // 
            this.restore_pbox.Image = global::Homunkulus.Properties.Resources.restore;
            this.restore_pbox.Location = new System.Drawing.Point(590, 3);
            this.restore_pbox.Name = "restore_pbox";
            this.restore_pbox.Size = new System.Drawing.Size(32, 32);
            this.restore_pbox.TabIndex = 14;
            this.restore_pbox.TabStop = false;
            // 
            // create_pbox
            // 
            this.create_pbox.Image = global::Homunkulus.Properties.Resources.create;
            this.create_pbox.Location = new System.Drawing.Point(452, 3);
            this.create_pbox.Name = "create_pbox";
            this.create_pbox.Size = new System.Drawing.Size(32, 32);
            this.create_pbox.TabIndex = 12;
            this.create_pbox.TabStop = false;
            this.create_pbox.Click += new System.EventHandler(this.create_pbox_Click);
            // 
            // plans_pbox
            // 
            this.plans_pbox.Image = global::Homunkulus.Properties.Resources.backupplans;
            this.plans_pbox.Location = new System.Drawing.Point(521, 3);
            this.plans_pbox.Name = "plans_pbox";
            this.plans_pbox.Size = new System.Drawing.Size(32, 32);
            this.plans_pbox.TabIndex = 13;
            this.plans_pbox.TabStop = false;
            this.plans_pbox.Click += new System.EventHandler(this.plans_pbox_Click);
            // 
            // home_pbox
            // 
            this.home_pbox.Image = global::Homunkulus.Properties.Resources.home;
            this.home_pbox.Location = new System.Drawing.Point(388, 3);
            this.home_pbox.Name = "home_pbox";
            this.home_pbox.Size = new System.Drawing.Size(32, 32);
            this.home_pbox.TabIndex = 11;
            this.home_pbox.TabStop = false;
            this.home_pbox.Click += new System.EventHandler(this.home_pbox_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Enabled = false;
            this.treeView1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(485, 590);
            this.treeView1.TabIndex = 5;
            this.treeView1.TabStop = false;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 644);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restore_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plans_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox restore_pbox;
        private PictureBox create_pbox;
        private PictureBox plans_pbox;
        private PictureBox home_pbox;
        private TreeView treeView1;
    }
}