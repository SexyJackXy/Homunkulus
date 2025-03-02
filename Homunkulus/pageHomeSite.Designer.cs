namespace Homunkulus
{
    partial class pageHomeSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pageHomeSite));
            PictureBox home_pbox;
            show_backup_btn = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            plans_pbox = new PictureBox();
            create_pbox = new PictureBox();
            create_btn = new Button();
            panel2 = new Panel();
            numb_execute = new Label();
            label2 = new Label();
            panel3 = new Panel();
            numb_backup = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            home_pbox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plans_pbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)create_pbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)home_pbox).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // show_backup_btn
            // 
            show_backup_btn.AutoSize = true;
            show_backup_btn.BackColor = Color.FromArgb(128, 19, 54);
            show_backup_btn.FlatAppearance.BorderSize = 0;
            show_backup_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(81, 10, 50);
            show_backup_btn.FlatStyle = FlatStyle.Flat;
            show_backup_btn.ForeColor = Color.White;
            show_backup_btn.Location = new Point(508, 535);
            show_backup_btn.Name = "show_backup_btn";
            show_backup_btn.Size = new Size(234, 40);
            show_backup_btn.TabIndex = 2;
            show_backup_btn.Text = "Show Backups";
            show_backup_btn.UseVisualStyleBackColor = false;
            show_backup_btn.Click += show_backup_btn_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(227, 233, 245);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(plans_pbox);
            panel1.Controls.Add(create_pbox);
            panel1.Controls.Add(home_pbox);
            panel1.Location = new Point(-3, 606);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 40);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.settings;
            pictureBox2.Location = new Point(947, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // plans_pbox
            // 
            plans_pbox.Image = (Image)resources.GetObject("plans_pbox.Image");
            plans_pbox.Location = new Point(551, 3);
            plans_pbox.Name = "plans_pbox";
            plans_pbox.Size = new Size(32, 32);
            plans_pbox.TabIndex = 9;
            plans_pbox.TabStop = false;
            plans_pbox.Click += plans_pbox_Click;
            // 
            // create_pbox
            // 
            create_pbox.Image = Properties.Resources.create;
            create_pbox.Location = new Point(482, 3);
            create_pbox.Name = "create_pbox";
            create_pbox.Size = new Size(32, 32);
            create_pbox.TabIndex = 8;
            create_pbox.TabStop = false;
            create_pbox.Click += create_pbox_Click;
            // 
            // home_pbox
            // 
            home_pbox.Image = (Image)resources.GetObject("home_pbox.Image");
            home_pbox.Location = new Point(418, 3);
            home_pbox.Name = "home_pbox";
            home_pbox.Size = new Size(32, 32);
            home_pbox.TabIndex = 7;
            home_pbox.TabStop = false;
            home_pbox.Click += home_pbox_Click;
            // 
            // create_btn
            // 
            create_btn.AutoSize = true;
            create_btn.BackColor = Color.FromArgb(128, 19, 54);
            create_btn.FlatAppearance.BorderSize = 0;
            create_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(81, 10, 50);
            create_btn.FlatStyle = FlatStyle.Flat;
            create_btn.ForeColor = Color.White;
            create_btn.Location = new Point(250, 535);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(234, 40);
            create_btn.TabIndex = 4;
            create_btn.Text = "Create Backup";
            create_btn.UseVisualStyleBackColor = false;
            create_btn.Click += create_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(numb_execute);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(250, 429);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 100);
            panel2.TabIndex = 5;
            // 
            // numb_execute
            // 
            numb_execute.AutoSize = true;
            numb_execute.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            numb_execute.Location = new Point(97, 25);
            numb_execute.Name = "numb_execute";
            numb_execute.Size = new Size(35, 37);
            numb_execute.TabIndex = 9;
            numb_execute.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 73);
            label2.Name = "label2";
            label2.Size = new Size(136, 18);
            label2.TabIndex = 8;
            label2.Text = "Backups executed";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(numb_backup);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(508, 429);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 100);
            panel3.TabIndex = 6;
            // 
            // numb_backup
            // 
            numb_backup.AutoSize = true;
            numb_backup.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            numb_backup.Location = new Point(99, 24);
            numb_backup.Name = "numb_backup";
            numb_backup.Size = new Size(35, 37);
            numb_backup.TabIndex = 8;
            numb_backup.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 72);
            label1.Name = "label1";
            label1.Size = new Size(98, 18);
            label1.TabIndex = 7;
            label1.Text = "Backupplans";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(375, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(234, 19);
            label3.Name = "label3";
            label3.Size = new Size(513, 41);
            label3.TabIndex = 8;
            label3.Text = "Welcome back to Homunkulus";
            // 
            // pageHomeSite
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(977, 644);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(create_btn);
            Controls.Add(panel1);
            Controls.Add(show_backup_btn);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "pageHomeSite";
            Text = "Landingpage";
            Load += Landingpage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)plans_pbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)create_pbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)home_pbox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox plans_pbox;
        private PictureBox create_pbox;
        private PictureBox home_pbox;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
    }
}