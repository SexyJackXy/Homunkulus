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
            this.import_backup_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.restore_pbox = new System.Windows.Forms.PictureBox();
            this.create_pbox = new System.Windows.Forms.PictureBox();
            this.plans_pbox = new System.Windows.Forms.PictureBox();
            this.home_pbox = new System.Windows.Forms.PictureBox();
            this.Destination_txt = new System.Windows.Forms.TextBox();
            this.add_folder_btn = new System.Windows.Forms.Button();
            this.Source_btn = new System.Windows.Forms.Label();
            this.Destination_btn = new System.Windows.Forms.Label();
            this.dest_folder_btn = new System.Windows.Forms.Button();
            this.source_rtb = new System.Windows.Forms.RichTextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.add_data_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.check_compress = new System.Windows.Forms.CheckBox();
            this.check_complimentary = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restore_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plans_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // import_backup_btn
            // 
            this.import_backup_btn.AutoSize = true;
            this.import_backup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.import_backup_btn.FlatAppearance.BorderSize = 0;
            this.import_backup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.import_backup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_backup_btn.ForeColor = System.Drawing.Color.White;
            this.import_backup_btn.Location = new System.Drawing.Point(331, 559);
            this.import_backup_btn.Name = "import_backup_btn";
            this.import_backup_btn.Size = new System.Drawing.Size(345, 40);
            this.import_backup_btn.TabIndex = 2;
            this.import_backup_btn.Text = "Load Backup";
            this.import_backup_btn.UseVisualStyleBackColor = false;
            this.import_backup_btn.Click += new System.EventHandler(this.import_backup_btn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.restore_pbox);
            this.panel1.Controls.Add(this.create_pbox);
            this.panel1.Controls.Add(this.plans_pbox);
            this.panel1.Controls.Add(this.home_pbox);
            this.panel1.Location = new System.Drawing.Point(-3, 606);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 40);
            this.panel1.TabIndex = 0;
            // 
            // restore_pbox
            // 
            this.restore_pbox.Image = global::Homunkulus.Properties.Resources.restore;
            this.restore_pbox.Location = new System.Drawing.Point(579, 5);
            this.restore_pbox.Name = "restore_pbox";
            this.restore_pbox.Size = new System.Drawing.Size(32, 32);
            this.restore_pbox.TabIndex = 17;
            this.restore_pbox.TabStop = false;
            this.restore_pbox.Click += new System.EventHandler(this.restore_pbox_Click);
            // 
            // create_pbox
            // 
            this.create_pbox.Image = global::Homunkulus.Properties.Resources.create;
            this.create_pbox.Location = new System.Drawing.Point(441, 5);
            this.create_pbox.Name = "create_pbox";
            this.create_pbox.Size = new System.Drawing.Size(32, 32);
            this.create_pbox.TabIndex = 15;
            this.create_pbox.TabStop = false;
            this.create_pbox.Click += new System.EventHandler(this.create_pbox_Click);
            // 
            // plans_pbox
            // 
            this.plans_pbox.Image = global::Homunkulus.Properties.Resources.backupplans;
            this.plans_pbox.Location = new System.Drawing.Point(510, 5);
            this.plans_pbox.Name = "plans_pbox";
            this.plans_pbox.Size = new System.Drawing.Size(32, 32);
            this.plans_pbox.TabIndex = 16;
            this.plans_pbox.TabStop = false;
            this.plans_pbox.Click += new System.EventHandler(this.plans_pbox_Click);
            // 
            // home_pbox
            // 
            this.home_pbox.Image = global::Homunkulus.Properties.Resources.home;
            this.home_pbox.Location = new System.Drawing.Point(377, 5);
            this.home_pbox.Name = "home_pbox";
            this.home_pbox.Size = new System.Drawing.Size(32, 32);
            this.home_pbox.TabIndex = 14;
            this.home_pbox.TabStop = false;
            this.home_pbox.Click += new System.EventHandler(this.home_pbox_Click);
            // 
            // Destination_txt
            // 
            this.Destination_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.Destination_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Destination_txt.Location = new System.Drawing.Point(12, 30);
            this.Destination_txt.Name = "Destination_txt";
            this.Destination_txt.Size = new System.Drawing.Size(794, 26);
            this.Destination_txt.TabIndex = 3;
            // 
            // add_folder_btn
            // 
            this.add_folder_btn.AutoSize = true;
            this.add_folder_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.add_folder_btn.FlatAppearance.BorderSize = 0;
            this.add_folder_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.add_folder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_folder_btn.ForeColor = System.Drawing.Color.White;
            this.add_folder_btn.Location = new System.Drawing.Point(812, 112);
            this.add_folder_btn.Name = "add_folder_btn";
            this.add_folder_btn.Size = new System.Drawing.Size(153, 28);
            this.add_folder_btn.TabIndex = 4;
            this.add_folder_btn.Text = "Add Folder";
            this.add_folder_btn.UseVisualStyleBackColor = false;
            this.add_folder_btn.Click += new System.EventHandler(this.src_btn_Click);
            // 
            // Source_btn
            // 
            this.Source_btn.AutoSize = true;
            this.Source_btn.Location = new System.Drawing.Point(12, 91);
            this.Source_btn.Name = "Source_btn";
            this.Source_btn.Size = new System.Drawing.Size(86, 18);
            this.Source_btn.TabIndex = 5;
            this.Source_btn.Text = "Add Folder";
            // 
            // Destination_btn
            // 
            this.Destination_btn.AutoSize = true;
            this.Destination_btn.Location = new System.Drawing.Point(12, 9);
            this.Destination_btn.Name = "Destination_btn";
            this.Destination_btn.Size = new System.Drawing.Size(184, 18);
            this.Destination_btn.TabIndex = 8;
            this.Destination_btn.Text = "Select Destination Folder";
            // 
            // dest_folder_btn
            // 
            this.dest_folder_btn.AutoSize = true;
            this.dest_folder_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.dest_folder_btn.FlatAppearance.BorderSize = 0;
            this.dest_folder_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.dest_folder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dest_folder_btn.ForeColor = System.Drawing.Color.White;
            this.dest_folder_btn.Location = new System.Drawing.Point(812, 30);
            this.dest_folder_btn.Name = "dest_folder_btn";
            this.dest_folder_btn.Size = new System.Drawing.Size(153, 28);
            this.dest_folder_btn.TabIndex = 7;
            this.dest_folder_btn.Text = "Add Folder";
            this.dest_folder_btn.UseVisualStyleBackColor = false;
            this.dest_folder_btn.Click += new System.EventHandler(this.dest_folder_btn_Click);
            // 
            // source_rtb
            // 
            this.source_rtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.source_rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.source_rtb.EnableAutoDragDrop = true;
            this.source_rtb.Location = new System.Drawing.Point(12, 112);
            this.source_rtb.Name = "source_rtb";
            this.source_rtb.Size = new System.Drawing.Size(794, 393);
            this.source_rtb.TabIndex = 9;
            this.source_rtb.TabStop = false;
            this.source_rtb.Text = "";
            // 
            // start_btn
            // 
            this.start_btn.AutoSize = true;
            this.start_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.start_btn.FlatAppearance.BorderSize = 0;
            this.start_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(12, 559);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(298, 40);
            this.start_btn.TabIndex = 10;
            this.start_btn.Text = "Start Backup";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // add_data_btn
            // 
            this.add_data_btn.AutoSize = true;
            this.add_data_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.add_data_btn.FlatAppearance.BorderSize = 0;
            this.add_data_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.add_data_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_data_btn.ForeColor = System.Drawing.Color.White;
            this.add_data_btn.Location = new System.Drawing.Point(812, 146);
            this.add_data_btn.Name = "add_data_btn";
            this.add_data_btn.Size = new System.Drawing.Size(153, 28);
            this.add_data_btn.TabIndex = 12;
            this.add_data_btn.Text = "Add Data";
            this.add_data_btn.UseVisualStyleBackColor = false;
            this.add_data_btn.Click += new System.EventHandler(this.add_data_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.AutoSize = true;
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(698, 559);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(267, 40);
            this.save_btn.TabIndex = 13;
            this.save_btn.Text = "Save Backup";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.AutoSize = true;
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(812, 477);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(153, 28);
            this.clear_btn.TabIndex = 14;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // check_compress
            // 
            this.check_compress.AutoSize = true;
            this.check_compress.BackColor = System.Drawing.Color.Transparent;
            this.check_compress.Location = new System.Drawing.Point(812, 180);
            this.check_compress.Name = "check_compress";
            this.check_compress.Size = new System.Drawing.Size(118, 22);
            this.check_compress.TabIndex = 15;
            this.check_compress.Text = "Compressed";
            this.check_compress.UseVisualStyleBackColor = false;
            this.check_compress.CheckedChanged += new System.EventHandler(this.check_compress_CheckedChanged);
            // 
            // check_complimentary
            // 
            this.check_complimentary.AutoSize = true;
            this.check_complimentary.Location = new System.Drawing.Point(812, 208);
            this.check_complimentary.Name = "check_complimentary";
            this.check_complimentary.Size = new System.Drawing.Size(132, 22);
            this.check_complimentary.TabIndex = 16;
            this.check_complimentary.Text = "Complimentary";
            this.check_complimentary.UseVisualStyleBackColor = true;
            this.check_complimentary.CheckedChanged += new System.EventHandler(this.check_complimentary_CheckedChanged);
            // 
            // createBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 644);
            this.Controls.Add(this.check_complimentary);
            this.Controls.Add(this.check_compress);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.add_data_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.source_rtb);
            this.Controls.Add(this.Destination_btn);
            this.Controls.Add(this.dest_folder_btn);
            this.Controls.Add(this.Source_btn);
            this.Controls.Add(this.add_folder_btn);
            this.Controls.Add(this.Destination_txt);
            this.Controls.Add(this.import_backup_btn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "createBackup";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restore_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plans_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private PictureBox restore_pbox;
        private PictureBox create_pbox;
        private PictureBox plans_pbox;
        private PictureBox home_pbox;
        private Button clear_btn;
        private CheckBox check_compress;
        private CheckBox check_complimentary;
    }
}