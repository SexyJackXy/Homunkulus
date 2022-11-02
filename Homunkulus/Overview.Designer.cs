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
            this.source_txt = new System.Windows.Forms.TextBox();
            this.src_btn = new System.Windows.Forms.Button();
            this.Source_btn = new System.Windows.Forms.Label();
            this.Destination_btn = new System.Windows.Forms.Label();
            this.dest_btn = new System.Windows.Forms.Button();
            this.source_rtb = new System.Windows.Forms.RichTextBox();
            this.start_btn = new System.Windows.Forms.Button();
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
            this.create_backup_btn.Location = new System.Drawing.Point(12, 402);
            this.create_backup_btn.Name = "create_backup_btn";
            this.create_backup_btn.Size = new System.Drawing.Size(271, 40);
            this.create_backup_btn.TabIndex = 1;
            this.create_backup_btn.Text = "Create Backup";
            this.create_backup_btn.UseVisualStyleBackColor = false;
            this.create_backup_btn.Click += new System.EventHandler(this.create_backup_btn_Click);
            // 
            // import_backup_btn
            // 
            this.import_backup_btn.AutoSize = true;
            this.import_backup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.import_backup_btn.FlatAppearance.BorderSize = 0;
            this.import_backup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.import_backup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_backup_btn.ForeColor = System.Drawing.Color.White;
            this.import_backup_btn.Location = new System.Drawing.Point(288, 402);
            this.import_backup_btn.Name = "import_backup_btn";
            this.import_backup_btn.Size = new System.Drawing.Size(268, 40);
            this.import_backup_btn.TabIndex = 2;
            this.import_backup_btn.Text = "Import Backup";
            this.import_backup_btn.UseVisualStyleBackColor = false;
            this.import_backup_btn.Click += new System.EventHandler(this.import_backup_btn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(-3, 495);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 45);
            this.panel1.TabIndex = 0;
            // 
            // source_txt
            // 
            this.source_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.source_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.source_txt.Location = new System.Drawing.Point(12, 136);
            this.source_txt.Name = "source_txt";
            this.source_txt.Size = new System.Drawing.Size(510, 26);
            this.source_txt.TabIndex = 3;
            // 
            // src_btn
            // 
            this.src_btn.AutoSize = true;
            this.src_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.src_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.src_btn.FlatAppearance.BorderSize = 0;
            this.src_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.src_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.src_btn.ForeColor = System.Drawing.Color.White;
            this.src_btn.Location = new System.Drawing.Point(526, 73);
            this.src_btn.Name = "src_btn";
            this.src_btn.Size = new System.Drawing.Size(30, 28);
            this.src_btn.TabIndex = 4;
            this.src_btn.Text = "...";
            this.src_btn.UseVisualStyleBackColor = false;
            this.src_btn.Click += new System.EventHandler(this.src_btn_Click);
            // 
            // Source_btn
            // 
            this.Source_btn.AutoSize = true;
            this.Source_btn.Location = new System.Drawing.Point(12, 7);
            this.Source_btn.Name = "Source_btn";
            this.Source_btn.Size = new System.Drawing.Size(86, 18);
            this.Source_btn.TabIndex = 5;
            this.Source_btn.Text = "Add Folder";
            // 
            // Destination_btn
            // 
            this.Destination_btn.AutoSize = true;
            this.Destination_btn.Location = new System.Drawing.Point(12, 115);
            this.Destination_btn.Name = "Destination_btn";
            this.Destination_btn.Size = new System.Drawing.Size(184, 18);
            this.Destination_btn.TabIndex = 8;
            this.Destination_btn.Text = "Select Destination Folder";
            // 
            // dest_btn
            // 
            this.dest_btn.AutoSize = true;
            this.dest_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dest_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.dest_btn.FlatAppearance.BorderSize = 0;
            this.dest_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.dest_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dest_btn.ForeColor = System.Drawing.Color.White;
            this.dest_btn.Location = new System.Drawing.Point(528, 133);
            this.dest_btn.Name = "dest_btn";
            this.dest_btn.Size = new System.Drawing.Size(30, 28);
            this.dest_btn.TabIndex = 7;
            this.dest_btn.Text = "...";
            this.dest_btn.UseVisualStyleBackColor = false;
            // 
            // source_rtb
            // 
            this.source_rtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.source_rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.source_rtb.EnableAutoDragDrop = true;
            this.source_rtb.Location = new System.Drawing.Point(12, 28);
            this.source_rtb.Name = "source_rtb";
            this.source_rtb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.source_rtb.Size = new System.Drawing.Size(510, 73);
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
            this.start_btn.Location = new System.Drawing.Point(12, 448);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(547, 40);
            this.start_btn.TabIndex = 10;
            this.start_btn.Text = "Start Backup";
            this.start_btn.UseVisualStyleBackColor = false;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 540);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.source_rtb);
            this.Controls.Add(this.Destination_btn);
            this.Controls.Add(this.dest_btn);
            this.Controls.Add(this.Source_btn);
            this.Controls.Add(this.src_btn);
            this.Controls.Add(this.source_txt);
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
        private TextBox source_txt;
        private Button src_btn;
        private Label Source_btn;
        private Label Destination_btn;
        private Button dest_btn;
        private RichTextBox source_rtb;
        private Button start_btn;
    }
}