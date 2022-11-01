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
            this.Destination_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // create_backup_btn
            // 
            this.create_backup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.create_backup_btn.FlatAppearance.BorderSize = 0;
            this.create_backup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(56)))), ((int)(((byte)(149)))));
            this.create_backup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_backup_btn.ForeColor = System.Drawing.Color.White;
            this.create_backup_btn.Location = new System.Drawing.Point(80, 490);
            this.create_backup_btn.Name = "create_backup_btn";
            this.create_backup_btn.Size = new System.Drawing.Size(211, 40);
            this.create_backup_btn.TabIndex = 1;
            this.create_backup_btn.Text = "Create Backup";
            this.create_backup_btn.UseVisualStyleBackColor = false;
            this.create_backup_btn.Click += new System.EventHandler(this.create_backup_btn_Click);
            // 
            // import_backup_btn
            // 
            this.import_backup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.import_backup_btn.FlatAppearance.BorderSize = 0;
            this.import_backup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(56)))), ((int)(((byte)(149)))));
            this.import_backup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_backup_btn.ForeColor = System.Drawing.Color.White;
            this.import_backup_btn.Location = new System.Drawing.Point(309, 490);
            this.import_backup_btn.Name = "import_backup_btn";
            this.import_backup_btn.Size = new System.Drawing.Size(211, 40);
            this.import_backup_btn.TabIndex = 2;
            this.import_backup_btn.Text = "Import Backup";
            this.import_backup_btn.UseVisualStyleBackColor = false;
            this.import_backup_btn.Click += new System.EventHandler(this.import_backup_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 541);
            this.panel1.TabIndex = 0;
            // 
            // source_txt
            // 
            this.source_txt.Location = new System.Drawing.Point(80, 28);
            this.source_txt.Name = "source_txt";
            this.source_txt.Size = new System.Drawing.Size(403, 26);
            this.source_txt.TabIndex = 3;
            // 
            // src_btn
            // 
            this.src_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.src_btn.FlatAppearance.BorderSize = 0;
            this.src_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(56)))), ((int)(((byte)(149)))));
            this.src_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.src_btn.ForeColor = System.Drawing.Color.White;
            this.src_btn.Location = new System.Drawing.Point(489, 28);
            this.src_btn.Name = "src_btn";
            this.src_btn.Size = new System.Drawing.Size(31, 26);
            this.src_btn.TabIndex = 4;
            this.src_btn.Text = "...";
            this.src_btn.UseVisualStyleBackColor = false;
            this.src_btn.Click += new System.EventHandler(this.src_btn_Click);
            // 
            // Source_btn
            // 
            this.Source_btn.AutoSize = true;
            this.Source_btn.Location = new System.Drawing.Point(80, 7);
            this.Source_btn.Name = "Source_btn";
            this.Source_btn.Size = new System.Drawing.Size(106, 18);
            this.Source_btn.TabIndex = 5;
            this.Source_btn.Text = "Select Source";
            // 
            // Destination_btn
            // 
            this.Destination_btn.AutoSize = true;
            this.Destination_btn.Location = new System.Drawing.Point(80, 68);
            this.Destination_btn.Name = "Destination_btn";
            this.Destination_btn.Size = new System.Drawing.Size(135, 18);
            this.Destination_btn.TabIndex = 8;
            this.Destination_btn.Text = "Select Destination";
            // 
            // dest_btn
            // 
            this.dest_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.dest_btn.FlatAppearance.BorderSize = 0;
            this.dest_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(56)))), ((int)(((byte)(149)))));
            this.dest_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dest_btn.ForeColor = System.Drawing.Color.White;
            this.dest_btn.Location = new System.Drawing.Point(489, 89);
            this.dest_btn.Name = "dest_btn";
            this.dest_btn.Size = new System.Drawing.Size(31, 26);
            this.dest_btn.TabIndex = 7;
            this.dest_btn.Text = "...";
            this.dest_btn.UseVisualStyleBackColor = false;
            // 
            // Destination_txt
            // 
            this.Destination_txt.Location = new System.Drawing.Point(80, 89);
            this.Destination_txt.Name = "Destination_txt";
            this.Destination_txt.Size = new System.Drawing.Size(403, 26);
            this.Destination_txt.TabIndex = 6;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(531, 540);
            this.Controls.Add(this.Destination_btn);
            this.Controls.Add(this.dest_btn);
            this.Controls.Add(this.Destination_txt);
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
        private TextBox Destination_txt;
    }
}