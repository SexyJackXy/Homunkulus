namespace Homunkulus
{
    partial class loadBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadBackup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.restore_pbox = new System.Windows.Forms.PictureBox();
            this.plans_pbox = new System.Windows.Forms.PictureBox();
            this.create_pbox = new System.Windows.Forms.PictureBox();
            this.home_pbox = new System.Windows.Forms.PictureBox();
            this.import_backup_btn = new System.Windows.Forms.Button();
            this.Content_rtb = new System.Windows.Forms.RichTextBox();
            this.path_tbx = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restore_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plans_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.restore_pbox);
            this.panel1.Controls.Add(this.plans_pbox);
            this.panel1.Controls.Add(this.create_pbox);
            this.panel1.Controls.Add(this.home_pbox);
            this.panel1.Location = new System.Drawing.Point(0, 604);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 40);
            this.panel1.TabIndex = 4;
            // 
            // restore_pbox
            // 
            this.restore_pbox.Image = global::Homunkulus.Properties.Resources.restore;
            this.restore_pbox.Location = new System.Drawing.Point(577, 5);
            this.restore_pbox.Name = "restore_pbox";
            this.restore_pbox.Size = new System.Drawing.Size(32, 32);
            this.restore_pbox.TabIndex = 10;
            this.restore_pbox.TabStop = false;
            // 
            // plans_pbox
            // 
            this.plans_pbox.Image = global::Homunkulus.Properties.Resources.backupplans;
            this.plans_pbox.Location = new System.Drawing.Point(508, 5);
            this.plans_pbox.Name = "plans_pbox";
            this.plans_pbox.Size = new System.Drawing.Size(32, 32);
            this.plans_pbox.TabIndex = 9;
            this.plans_pbox.TabStop = false;
            // 
            // create_pbox
            // 
            this.create_pbox.Image = global::Homunkulus.Properties.Resources.create;
            this.create_pbox.Location = new System.Drawing.Point(439, 5);
            this.create_pbox.Name = "create_pbox";
            this.create_pbox.Size = new System.Drawing.Size(32, 32);
            this.create_pbox.TabIndex = 8;
            this.create_pbox.TabStop = false;
            // 
            // home_pbox
            // 
            this.home_pbox.Image = global::Homunkulus.Properties.Resources.home;
            this.home_pbox.Location = new System.Drawing.Point(375, 5);
            this.home_pbox.Name = "home_pbox";
            this.home_pbox.Size = new System.Drawing.Size(32, 32);
            this.home_pbox.TabIndex = 7;
            this.home_pbox.TabStop = false;
            // 
            // import_backup_btn
            // 
            this.import_backup_btn.AutoSize = true;
            this.import_backup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.import_backup_btn.FlatAppearance.BorderSize = 0;
            this.import_backup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.import_backup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_backup_btn.ForeColor = System.Drawing.Color.White;
            this.import_backup_btn.Location = new System.Drawing.Point(146, 557);
            this.import_backup_btn.Name = "import_backup_btn";
            this.import_backup_btn.Size = new System.Drawing.Size(345, 40);
            this.import_backup_btn.TabIndex = 5;
            this.import_backup_btn.Text = "Import ";
            this.import_backup_btn.UseVisualStyleBackColor = false;
            this.import_backup_btn.Click += new System.EventHandler(this.import_backup_btn_Click);
            // 
            // Content_rtb
            // 
            this.Content_rtb.Location = new System.Drawing.Point(12, 63);
            this.Content_rtb.Name = "Content_rtb";
            this.Content_rtb.Size = new System.Drawing.Size(953, 488);
            this.Content_rtb.TabIndex = 6;
            this.Content_rtb.Text = "";
            // 
            // path_tbx
            // 
            this.path_tbx.Location = new System.Drawing.Point(12, 12);
            this.path_tbx.Name = "path_tbx";
            this.path_tbx.Size = new System.Drawing.Size(953, 26);
            this.path_tbx.TabIndex = 7;
            // 
            // save_btn
            // 
            this.save_btn.AutoSize = true;
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(497, 557);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(345, 40);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save ";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Backupplans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 644);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.path_tbx);
            this.Controls.Add(this.Content_rtb);
            this.Controls.Add(this.import_backup_btn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Backupplans";
            this.Text = "Backupplans";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restore_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plans_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox restore_pbox;
        private PictureBox plans_pbox;
        private PictureBox create_pbox;
        private PictureBox home_pbox;
        private Button import_backup_btn;
        private RichTextBox Content_rtb;
        private TextBox path_tbx;
        private Button save_btn;
    }
}