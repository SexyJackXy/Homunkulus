namespace Homunkulus
{
    partial class Landingpage
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
            this.show_backup_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.restore_pbox = new System.Windows.Forms.PictureBox();
            this.plans_pbox = new System.Windows.Forms.PictureBox();
            this.create_pbox = new System.Windows.Forms.PictureBox();
            this.home_pbox = new System.Windows.Forms.PictureBox();
            this.create_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numb_execute = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numb_backup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restore_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plans_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pbox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // show_backup_btn
            // 
            this.show_backup_btn.AutoSize = true;
            this.show_backup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.show_backup_btn.FlatAppearance.BorderSize = 0;
            this.show_backup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.show_backup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_backup_btn.ForeColor = System.Drawing.Color.White;
            this.show_backup_btn.Location = new System.Drawing.Point(508, 535);
            this.show_backup_btn.Name = "show_backup_btn";
            this.show_backup_btn.Size = new System.Drawing.Size(234, 40);
            this.show_backup_btn.TabIndex = 2;
            this.show_backup_btn.Text = "Show Backups";
            this.show_backup_btn.UseVisualStyleBackColor = false;
            this.show_backup_btn.Click += new System.EventHandler(this.show_backup_btn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.restore_pbox);
            this.panel1.Controls.Add(this.plans_pbox);
            this.panel1.Controls.Add(this.create_pbox);
            this.panel1.Controls.Add(this.home_pbox);
            this.panel1.Location = new System.Drawing.Point(0, 605);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 40);
            this.panel1.TabIndex = 3;
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
            this.plans_pbox.Click += new System.EventHandler(this.plans_pbox_Click);
            // 
            // create_pbox
            // 
            this.create_pbox.Image = global::Homunkulus.Properties.Resources.create;
            this.create_pbox.Location = new System.Drawing.Point(439, 5);
            this.create_pbox.Name = "create_pbox";
            this.create_pbox.Size = new System.Drawing.Size(32, 32);
            this.create_pbox.TabIndex = 8;
            this.create_pbox.TabStop = false;
            this.create_pbox.Click += new System.EventHandler(this.create_pbox_Click);
            // 
            // home_pbox
            // 
            this.home_pbox.Image = global::Homunkulus.Properties.Resources.home;
            this.home_pbox.Location = new System.Drawing.Point(375, 5);
            this.home_pbox.Name = "home_pbox";
            this.home_pbox.Size = new System.Drawing.Size(32, 32);
            this.home_pbox.TabIndex = 7;
            this.home_pbox.TabStop = false;
            this.home_pbox.Click += new System.EventHandler(this.home_pbox_Click);
            // 
            // create_btn
            // 
            this.create_btn.AutoSize = true;
            this.create_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.create_btn.FlatAppearance.BorderSize = 0;
            this.create_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.create_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_btn.ForeColor = System.Drawing.Color.White;
            this.create_btn.Location = new System.Drawing.Point(250, 535);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(234, 40);
            this.create_btn.TabIndex = 4;
            this.create_btn.Text = "Create Backup";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.numb_execute);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(250, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 100);
            this.panel2.TabIndex = 5;
            // 
            // numb_execute
            // 
            this.numb_execute.AutoSize = true;
            this.numb_execute.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numb_execute.Location = new System.Drawing.Point(97, 25);
            this.numb_execute.Name = "numb_execute";
            this.numb_execute.Size = new System.Drawing.Size(35, 37);
            this.numb_execute.TabIndex = 9;
            this.numb_execute.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Backups executed";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.numb_backup);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(508, 429);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 100);
            this.panel3.TabIndex = 6;
            // 
            // numb_backup
            // 
            this.numb_backup.AutoSize = true;
            this.numb_backup.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numb_backup.Location = new System.Drawing.Point(99, 24);
            this.numb_backup.Name = "numb_backup";
            this.numb_backup.Size = new System.Drawing.Size(35, 37);
            this.numb_backup.TabIndex = 8;
            this.numb_backup.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Backupplans";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Homunkulus.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(365, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(234, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(513, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Welcome back to Homunkulus";
            // 
            // Landingpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 644);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.show_backup_btn);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Landingpage";
            this.Text = "Landingpage";
            this.Load += new System.EventHandler(this.Landingpage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restore_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plans_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pbox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button show_backup_btn;
        private Panel panel1;
        private Button create_btn;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label numb_backup;
        private Label numb_execute;
        private Label label2;
        private PictureBox restore_pbox;
        private PictureBox plans_pbox;
        private PictureBox create_pbox;
        private PictureBox home_pbox;
        private PictureBox pictureBox1;
        private Label label3;
    }
}