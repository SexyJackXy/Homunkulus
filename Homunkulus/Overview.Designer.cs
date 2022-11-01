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
            this.panel1 = new System.Windows.Forms.Panel();
            this.create_backup_btn = new System.Windows.Forms.Button();
            this.import_backup_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // create_backup_btn
            // 
            this.create_backup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.create_backup_btn.FlatAppearance.BorderSize = 0;
            this.create_backup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(170)))), ((int)(((byte)(185)))));
            this.create_backup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_backup_btn.ForeColor = System.Drawing.Color.White;
            this.create_backup_btn.Location = new System.Drawing.Point(380, 490);
            this.create_backup_btn.Name = "create_backup_btn";
            this.create_backup_btn.Size = new System.Drawing.Size(167, 38);
            this.create_backup_btn.TabIndex = 1;
            this.create_backup_btn.Text = "Create Backup";
            this.create_backup_btn.UseVisualStyleBackColor = false;
            this.create_backup_btn.Click += new System.EventHandler(this.create_backup_btn_Click);
            // 
            // import_backup_btn
            // 
            this.import_backup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.import_backup_btn.FlatAppearance.BorderSize = 0;
            this.import_backup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(105)))), ((int)(((byte)(198)))));
            this.import_backup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_backup_btn.ForeColor = System.Drawing.Color.White;
            this.import_backup_btn.Location = new System.Drawing.Point(578, 490);
            this.import_backup_btn.Name = "import_backup_btn";
            this.import_backup_btn.Size = new System.Drawing.Size(167, 38);
            this.import_backup_btn.TabIndex = 2;
            this.import_backup_btn.Text = "Import Backup";
            this.import_backup_btn.UseVisualStyleBackColor = false;
            this.import_backup_btn.Click += new System.EventHandler(this.import_backup_btn_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1029, 540);
            this.Controls.Add(this.import_backup_btn);
            this.Controls.Add(this.create_backup_btn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Overview";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button create_backup_btn;
        private Button import_backup_btn;
    }
}