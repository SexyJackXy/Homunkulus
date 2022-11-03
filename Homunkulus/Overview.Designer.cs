namespace Homunkulus
{
    partial class Overview
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
            this.create_backup_btn = new System.Windows.Forms.Button();
            this.import_backup_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Destination_txt = new System.Windows.Forms.TextBox();
            this.add_folder_btn = new System.Windows.Forms.Button();
            this.Source_btn = new System.Windows.Forms.Label();
            this.Destination_btn = new System.Windows.Forms.Label();
            this.dest_folder_btn = new System.Windows.Forms.Button();
            this.source_rtb = new System.Windows.Forms.RichTextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.multiple_folder_btn = new System.Windows.Forms.Button();
            this.add_data_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_backup_btn
            // 
            this.create_backup_btn.AutoSize = true;
            this.create_backup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.create_backup_btn.FlatAppearance.BorderSize = 0;
            this.create_backup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.create_backup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_backup_btn.ForeColor = System.Drawing.Color.White;
            this.create_backup_btn.Location = new System.Drawing.Point(251, 559);
            this.create_backup_btn.Name = "create_backup_btn";
            this.create_backup_btn.Size = new System.Drawing.Size(234, 40);
            this.create_backup_btn.TabIndex = 1;
            this.create_backup_btn.Text = "Create Backup";
            this.create_backup_btn.UseVisualStyleBackColor = false;
            // 
            // import_backup_btn
            // 
            this.import_backup_btn.AutoSize = true;
            this.import_backup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.import_backup_btn.FlatAppearance.BorderSize = 0;
            this.import_backup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.import_backup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_backup_btn.ForeColor = System.Drawing.Color.White;
            this.import_backup_btn.Location = new System.Drawing.Point(491, 559);
            this.import_backup_btn.Name = "import_backup_btn";
            this.import_backup_btn.Size = new System.Drawing.Size(234, 40);
            this.import_backup_btn.TabIndex = 2;
            this.import_backup_btn.Text = "Import Backup";
            this.import_backup_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(-3, 606);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 40);
            this.panel1.TabIndex = 0;
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
            this.add_folder_btn.Location = new System.Drawing.Point(812, 146);
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
            this.source_rtb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            this.start_btn.Size = new System.Drawing.Size(234, 40);
            this.start_btn.TabIndex = 10;
            this.start_btn.Text = "Start Backup";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // multiple_folder_btn
            // 
            this.multiple_folder_btn.AutoSize = true;
            this.multiple_folder_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.multiple_folder_btn.FlatAppearance.BorderSize = 0;
            this.multiple_folder_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.multiple_folder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiple_folder_btn.ForeColor = System.Drawing.Color.White;
            this.multiple_folder_btn.Location = new System.Drawing.Point(812, 112);
            this.multiple_folder_btn.Name = "multiple_folder_btn";
            this.multiple_folder_btn.Size = new System.Drawing.Size(153, 28);
            this.multiple_folder_btn.TabIndex = 11;
            this.multiple_folder_btn.Text = "Add Multiple Folder";
            this.multiple_folder_btn.UseVisualStyleBackColor = false;
            // 
            // add_data_btn
            // 
            this.add_data_btn.AutoSize = true;
            this.add_data_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.add_data_btn.FlatAppearance.BorderSize = 0;
            this.add_data_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.add_data_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_data_btn.ForeColor = System.Drawing.Color.White;
            this.add_data_btn.Location = new System.Drawing.Point(812, 180);
            this.add_data_btn.Name = "add_data_btn";
            this.add_data_btn.Size = new System.Drawing.Size(153, 28);
            this.add_data_btn.TabIndex = 12;
            this.add_data_btn.Text = "Add Data";
            this.add_data_btn.UseVisualStyleBackColor = false;
            this.add_data_btn.Click += new System.EventHandler(this.add_data_btn_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(731, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save Backup";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_data_btn);
            this.Controls.Add(this.multiple_folder_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.source_rtb);
            this.Controls.Add(this.Destination_btn);
            this.Controls.Add(this.dest_folder_btn);
            this.Controls.Add(this.Source_btn);
            this.Controls.Add(this.add_folder_btn);
            this.Controls.Add(this.Destination_txt);
            this.Controls.Add(this.import_backup_btn);
            this.Controls.Add(this.create_backup_btn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Overview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button create_backup_btn;
        private Button import_backup_btn;
        private Panel panel1;
        private TextBox Destination_txt;
        private Button add_folder_btn;
        private Label Source_btn;
        private Label Destination_btn;
        private Button dest_folder_btn;
        private RichTextBox source_rtb;
        private Button start_btn;
        private Button multiple_folder_btn;
        private Button add_data_btn;
        private Button button1;
    }
}