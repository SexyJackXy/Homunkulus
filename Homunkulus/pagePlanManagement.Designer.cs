namespace Homunkulus
{
    partial class pagePlanManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagePlanManagement));
            panel1 = new Panel();
            create_pbox = new PictureBox();
            plans_pbox = new PictureBox();
            home_pbox = new PictureBox();
            Load_btn = new Button();
            treeView2 = new TreeView();
            Open_btn = new Button();
            back_btn = new Button();
            Edit_btn = new Button();
            open_backups_btn = new Button();
            edit_rtb = new RichTextBox();
            save_Changes_btn = new Button();
            label1 = new Label();
            folderName_tbox = new TextBox();
            delete_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)create_pbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plans_pbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)home_pbox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(227, 233, 245);
            panel1.Controls.Add(create_pbox);
            panel1.Controls.Add(plans_pbox);
            panel1.Controls.Add(home_pbox);
            panel1.Location = new Point(-3, 606);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 38);
            panel1.TabIndex = 4;
            // 
            // create_pbox
            // 
            create_pbox.Image = Properties.Resources.create;
            create_pbox.Location = new Point(479, 3);
            create_pbox.Name = "create_pbox";
            create_pbox.Size = new Size(32, 32);
            create_pbox.TabIndex = 12;
            create_pbox.TabStop = false;
            create_pbox.Click += create_pbox_Click;
            // 
            // plans_pbox
            // 
            plans_pbox.Image = Properties.Resources.backupplans;
            plans_pbox.Location = new Point(548, 3);
            plans_pbox.Name = "plans_pbox";
            plans_pbox.Size = new Size(32, 32);
            plans_pbox.TabIndex = 13;
            plans_pbox.TabStop = false;
            plans_pbox.Click += plans_pbox_Click;
            // 
            // home_pbox
            // 
            home_pbox.Image = Properties.Resources.home;
            home_pbox.Location = new Point(415, 3);
            home_pbox.Name = "home_pbox";
            home_pbox.Size = new Size(32, 32);
            home_pbox.TabIndex = 11;
            home_pbox.TabStop = false;
            home_pbox.Click += home_pbox_Click;
            // 
            // Load_btn
            // 
            Load_btn.AutoSize = true;
            Load_btn.BackColor = Color.FromArgb(128, 19, 54);
            Load_btn.FlatStyle = FlatStyle.Flat;
            Load_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Load_btn.ForeColor = Color.White;
            Load_btn.Location = new Point(812, 12);
            Load_btn.Name = "Load_btn";
            Load_btn.Size = new Size(153, 30);
            Load_btn.TabIndex = 6;
            Load_btn.Text = "Load";
            Load_btn.UseVisualStyleBackColor = false;
            Load_btn.Click += Load_btn_Click;
            // 
            // treeView2
            // 
            treeView2.BackColor = Color.FromArgb(220, 221, 225);
            treeView2.Location = new Point(171, 12);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(635, 590);
            treeView2.TabIndex = 7;
            // 
            // Open_btn
            // 
            Open_btn.AutoSize = true;
            Open_btn.BackColor = Color.FromArgb(128, 19, 54);
            Open_btn.FlatStyle = FlatStyle.Flat;
            Open_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Open_btn.ForeColor = Color.White;
            Open_btn.Location = new Point(812, 84);
            Open_btn.Name = "Open_btn";
            Open_btn.Size = new Size(153, 30);
            Open_btn.TabIndex = 8;
            Open_btn.Text = "Open";
            Open_btn.UseVisualStyleBackColor = false;
            Open_btn.Click += Open_btn_Click;
            // 
            // back_btn
            // 
            back_btn.AutoSize = true;
            back_btn.BackColor = Color.FromArgb(128, 19, 54);
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            back_btn.ForeColor = Color.White;
            back_btn.Location = new Point(12, 12);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(153, 30);
            back_btn.TabIndex = 9;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // Edit_btn
            // 
            Edit_btn.AutoSize = true;
            Edit_btn.BackColor = Color.FromArgb(128, 19, 54);
            Edit_btn.FlatStyle = FlatStyle.Flat;
            Edit_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Edit_btn.ForeColor = Color.White;
            Edit_btn.Location = new Point(812, 48);
            Edit_btn.Name = "Edit_btn";
            Edit_btn.Size = new Size(153, 30);
            Edit_btn.TabIndex = 10;
            Edit_btn.Text = "Edit";
            Edit_btn.UseVisualStyleBackColor = false;
            Edit_btn.Click += Edit_btn_Click;
            // 
            // open_backups_btn
            // 
            open_backups_btn.AutoSize = true;
            open_backups_btn.BackColor = Color.FromArgb(128, 19, 54);
            open_backups_btn.FlatStyle = FlatStyle.Flat;
            open_backups_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            open_backups_btn.ForeColor = Color.White;
            open_backups_btn.Location = new Point(812, 572);
            open_backups_btn.Name = "open_backups_btn";
            open_backups_btn.Size = new Size(153, 30);
            open_backups_btn.TabIndex = 11;
            open_backups_btn.Text = "Open Backups";
            open_backups_btn.UseVisualStyleBackColor = false;
            open_backups_btn.Click += open_backups_btn_Click;
            // 
            // edit_rtb
            // 
            edit_rtb.BackColor = Color.FromArgb(220, 221, 225);
            edit_rtb.BorderStyle = BorderStyle.FixedSingle;
            edit_rtb.Location = new Point(171, 48);
            edit_rtb.Name = "edit_rtb";
            edit_rtb.Size = new Size(635, 554);
            edit_rtb.TabIndex = 12;
            edit_rtb.Text = "";
            edit_rtb.Visible = false;
            // 
            // save_Changes_btn
            // 
            save_Changes_btn.AutoSize = true;
            save_Changes_btn.BackColor = Color.FromArgb(128, 19, 54);
            save_Changes_btn.FlatStyle = FlatStyle.Flat;
            save_Changes_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            save_Changes_btn.ForeColor = Color.White;
            save_Changes_btn.Location = new Point(12, 48);
            save_Changes_btn.Name = "save_Changes_btn";
            save_Changes_btn.Size = new Size(153, 30);
            save_Changes_btn.TabIndex = 13;
            save_Changes_btn.Text = "Save";
            save_Changes_btn.UseVisualStyleBackColor = false;
            save_Changes_btn.Visible = false;
            save_Changes_btn.Click += save_Changes_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Arial", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(36, 90);
            label1.Name = "label1";
            label1.Size = new Size(105, 24);
            label1.TabIndex = 14;
            label1.Text = "Edit Mode";
            label1.Visible = false;
            // 
            // folderName_tbox
            // 
            folderName_tbox.BackColor = Color.FromArgb(220, 221, 225);
            folderName_tbox.BorderStyle = BorderStyle.FixedSingle;
            folderName_tbox.Location = new Point(171, 12);
            folderName_tbox.Name = "folderName_tbox";
            folderName_tbox.Size = new Size(635, 26);
            folderName_tbox.TabIndex = 15;
            folderName_tbox.Visible = false;
            // 
            // delete_btn
            // 
            delete_btn.AutoSize = true;
            delete_btn.BackColor = Color.FromArgb(128, 19, 54);
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(812, 120);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(153, 30);
            delete_btn.TabIndex = 16;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // pagePlanManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(977, 644);
            Controls.Add(delete_btn);
            Controls.Add(folderName_tbox);
            Controls.Add(label1);
            Controls.Add(save_Changes_btn);
            Controls.Add(edit_rtb);
            Controls.Add(open_backups_btn);
            Controls.Add(Edit_btn);
            Controls.Add(back_btn);
            Controls.Add(Open_btn);
            Controls.Add(treeView2);
            Controls.Add(Load_btn);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "pagePlanManagement";
            Text = "pagePlanManagement";
            Load += History_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)create_pbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)plans_pbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)home_pbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox create_pbox;
        private PictureBox plans_pbox;
        private PictureBox home_pbox;
        private Button Load_btn;
        private TreeView treeView2;
        private Button Open_btn;
        private Button back_btn;
        private Button Edit_btn;
        private Button open_backups_btn;
        private RichTextBox edit_rtb;
        private Button save_Changes_btn;
        private Label label1;
        private TextBox folderName_tbox;
        private Button delete_btn;
    }
}