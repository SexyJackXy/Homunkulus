namespace Homunkulus
{
    partial class createBackup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createBackup));
            import_backup_btn = new Button();
            panel1 = new Panel();
            create_pbox = new PictureBox();
            plans_pbox = new PictureBox();
            home_pbox = new PictureBox();
            Destination_txt = new TextBox();
            add_folder_btn = new Button();
            Source_btn = new Label();
            Destination_btn = new Label();
            dest_folder_btn = new Button();
            source_rtb = new RichTextBox();
            start_btn = new Button();
            add_data_btn = new Button();
            save_btn = new Button();
            clear_btn = new Button();
            check_compress = new CheckBox();
            check_incremental = new CheckBox();
            multifolder_select_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)create_pbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plans_pbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)home_pbox).BeginInit();
            SuspendLayout();
            // 
            // import_backup_btn
            // 
            import_backup_btn.AutoSize = true;
            import_backup_btn.BackColor = Color.FromArgb(128, 19, 54);
            import_backup_btn.FlatAppearance.BorderSize = 0;
            import_backup_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(81, 10, 50);
            import_backup_btn.FlatStyle = FlatStyle.Flat;
            import_backup_btn.ForeColor = Color.White;
            import_backup_btn.Location = new Point(331, 559);
            import_backup_btn.Name = "import_backup_btn";
            import_backup_btn.Size = new Size(345, 40);
            import_backup_btn.TabIndex = 2;
            import_backup_btn.Text = "Load Backup";
            import_backup_btn.UseVisualStyleBackColor = false;
            import_backup_btn.Click += import_backup_btn_Click;
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
            panel1.Size = new Size(982, 40);
            panel1.TabIndex = 0;
            // 
            // create_pbox
            // 
            create_pbox.Image = Properties.Resources.create;
            create_pbox.Location = new Point(480, 3);
            create_pbox.Name = "create_pbox";
            create_pbox.Size = new Size(32, 32);
            create_pbox.TabIndex = 15;
            create_pbox.TabStop = false;
            create_pbox.Click += create_pbox_Click;
            // 
            // plans_pbox
            // 
            plans_pbox.Image = Properties.Resources.backupplans;
            plans_pbox.Location = new Point(549, 3);
            plans_pbox.Name = "plans_pbox";
            plans_pbox.Size = new Size(32, 32);
            plans_pbox.TabIndex = 16;
            plans_pbox.TabStop = false;
            plans_pbox.Click += plans_pbox_Click;
            // 
            // home_pbox
            // 
            home_pbox.Image = Properties.Resources.home;
            home_pbox.Location = new Point(416, 3);
            home_pbox.Name = "home_pbox";
            home_pbox.Size = new Size(32, 32);
            home_pbox.TabIndex = 14;
            home_pbox.TabStop = false;
            home_pbox.Click += home_pbox_Click;
            // 
            // Destination_txt
            // 
            Destination_txt.BackColor = Color.FromArgb(220, 221, 225);
            Destination_txt.BorderStyle = BorderStyle.FixedSingle;
            Destination_txt.Location = new Point(12, 30);
            Destination_txt.Name = "Destination_txt";
            Destination_txt.Size = new Size(794, 26);
            Destination_txt.TabIndex = 3;
            // 
            // add_folder_btn
            // 
            add_folder_btn.AutoSize = true;
            add_folder_btn.BackColor = Color.FromArgb(128, 19, 54);
            add_folder_btn.FlatAppearance.BorderSize = 0;
            add_folder_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(81, 10, 50);
            add_folder_btn.FlatStyle = FlatStyle.Flat;
            add_folder_btn.ForeColor = Color.White;
            add_folder_btn.Location = new Point(812, 112);
            add_folder_btn.Name = "add_folder_btn";
            add_folder_btn.Size = new Size(153, 28);
            add_folder_btn.TabIndex = 4;
            add_folder_btn.Text = "Add Folder";
            add_folder_btn.UseVisualStyleBackColor = false;
            add_folder_btn.Click += src_btn_Click;
            // 
            // Source_btn
            // 
            Source_btn.AutoSize = true;
            Source_btn.Location = new Point(12, 91);
            Source_btn.Name = "Source_btn";
            Source_btn.Size = new Size(86, 18);
            Source_btn.TabIndex = 5;
            Source_btn.Text = "Add Folder";
            // 
            // Destination_btn
            // 
            Destination_btn.AutoSize = true;
            Destination_btn.Location = new Point(12, 9);
            Destination_btn.Name = "Destination_btn";
            Destination_btn.Size = new Size(184, 18);
            Destination_btn.TabIndex = 8;
            Destination_btn.Text = "Select Destination Folder";
            // 
            // dest_folder_btn
            // 
            dest_folder_btn.AutoSize = true;
            dest_folder_btn.BackColor = Color.FromArgb(128, 19, 54);
            dest_folder_btn.FlatAppearance.BorderSize = 0;
            dest_folder_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(81, 10, 50);
            dest_folder_btn.FlatStyle = FlatStyle.Flat;
            dest_folder_btn.ForeColor = Color.White;
            dest_folder_btn.Location = new Point(812, 30);
            dest_folder_btn.Name = "dest_folder_btn";
            dest_folder_btn.Size = new Size(153, 28);
            dest_folder_btn.TabIndex = 7;
            dest_folder_btn.Text = "Add Folder";
            dest_folder_btn.UseVisualStyleBackColor = false;
            dest_folder_btn.Click += dest_folder_btn_Click;
            // 
            // source_rtb
            // 
            source_rtb.BackColor = Color.FromArgb(220, 221, 225);
            source_rtb.BorderStyle = BorderStyle.None;
            source_rtb.EnableAutoDragDrop = true;
            source_rtb.Location = new Point(12, 112);
            source_rtb.Name = "source_rtb";
            source_rtb.ReadOnly = true;
            source_rtb.Size = new Size(794, 393);
            source_rtb.TabIndex = 9;
            source_rtb.TabStop = false;
            source_rtb.Text = "";
            // 
            // start_btn
            // 
            start_btn.AutoSize = true;
            start_btn.BackColor = Color.FromArgb(128, 19, 54);
            start_btn.FlatAppearance.BorderSize = 0;
            start_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(81, 10, 50);
            start_btn.FlatStyle = FlatStyle.Flat;
            start_btn.ForeColor = Color.White;
            start_btn.Location = new Point(12, 559);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(298, 40);
            start_btn.TabIndex = 10;
            start_btn.Text = "Start Backup";
            start_btn.UseVisualStyleBackColor = false;
            start_btn.Click += start_btn_Click;
            // 
            // add_data_btn
            // 
            add_data_btn.AutoSize = true;
            add_data_btn.BackColor = Color.FromArgb(128, 19, 54);
            add_data_btn.FlatAppearance.BorderSize = 0;
            add_data_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(81, 10, 50);
            add_data_btn.FlatStyle = FlatStyle.Flat;
            add_data_btn.ForeColor = Color.White;
            add_data_btn.Location = new Point(812, 146);
            add_data_btn.Name = "add_data_btn";
            add_data_btn.Size = new Size(153, 28);
            add_data_btn.TabIndex = 12;
            add_data_btn.Text = "Add Data";
            add_data_btn.UseVisualStyleBackColor = false;
            add_data_btn.Click += add_data_btn_Click;
            // 
            // save_btn
            // 
            save_btn.AutoSize = true;
            save_btn.BackColor = Color.FromArgb(128, 19, 54);
            save_btn.FlatAppearance.BorderSize = 0;
            save_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(81, 10, 50);
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.ForeColor = Color.White;
            save_btn.Location = new Point(698, 559);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(267, 40);
            save_btn.TabIndex = 13;
            save_btn.Text = "Save Backup";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.AutoSize = true;
            clear_btn.BackColor = Color.FromArgb(128, 19, 54);
            clear_btn.FlatAppearance.BorderSize = 0;
            clear_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(81, 10, 50);
            clear_btn.FlatStyle = FlatStyle.Flat;
            clear_btn.ForeColor = Color.White;
            clear_btn.Location = new Point(812, 477);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(153, 28);
            clear_btn.TabIndex = 14;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // check_compress
            // 
            check_compress.AutoSize = true;
            check_compress.BackColor = Color.Transparent;
            check_compress.Location = new Point(812, 215);
            check_compress.Name = "check_compress";
            check_compress.Size = new Size(118, 22);
            check_compress.TabIndex = 15;
            check_compress.Text = "Compressed";
            check_compress.UseVisualStyleBackColor = false;
            // 
            // check_incremental
            // 
            check_incremental.AutoSize = true;
            check_incremental.Location = new Point(812, 243);
            check_incremental.Name = "check_incremental";
            check_incremental.Size = new Size(106, 22);
            check_incremental.TabIndex = 16;
            check_incremental.Text = "Incremental";
            check_incremental.UseVisualStyleBackColor = true;
            // 
            // multifolder_select_btn
            // 
            multifolder_select_btn.AutoSize = true;
            multifolder_select_btn.BackColor = Color.FromArgb(198, 149, 166);
            multifolder_select_btn.Enabled = false;
            multifolder_select_btn.FlatAppearance.BorderSize = 0;
            multifolder_select_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(81, 10, 50);
            multifolder_select_btn.FlatStyle = FlatStyle.Flat;
            multifolder_select_btn.ForeColor = Color.White;
            multifolder_select_btn.Location = new Point(812, 180);
            multifolder_select_btn.Name = "multifolder_select_btn";
            multifolder_select_btn.Size = new Size(153, 28);
            multifolder_select_btn.TabIndex = 17;
            multifolder_select_btn.Text = "Multifolder Select";
            multifolder_select_btn.UseVisualStyleBackColor = false;
            // 
            // createBackup
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(977, 644);
            Controls.Add(multifolder_select_btn);
            Controls.Add(check_incremental);
            Controls.Add(check_compress);
            Controls.Add(clear_btn);
            Controls.Add(save_btn);
            Controls.Add(add_data_btn);
            Controls.Add(start_btn);
            Controls.Add(source_rtb);
            Controls.Add(Destination_btn);
            Controls.Add(dest_folder_btn);
            Controls.Add(Source_btn);
            Controls.Add(add_folder_btn);
            Controls.Add(Destination_txt);
            Controls.Add(import_backup_btn);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "createBackup";
            Load += Overview_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)create_pbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)plans_pbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)home_pbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button import_backup_btn;
        private Panel panel1;
        private TextBox Destination_txt;
        private Button add_folder_btn;
        private Label Source_btn;
        private Label Destination_btn;
        private Button dest_folder_btn;
        private RichTextBox source_rtb;
        private Button start_btn;
        private Button add_data_btn;
        private Button save_btn;
        private PictureBox create_pbox;
        private PictureBox plans_pbox;
        private PictureBox home_pbox;
        private Button clear_btn;
        private CheckBox check_compress;
        private CheckBox check_incremental;
        private Button multifolder_select_btn;
    }
}