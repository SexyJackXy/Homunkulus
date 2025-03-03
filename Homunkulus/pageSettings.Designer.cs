namespace Homunkulus
{
    partial class pageSettings
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
            file_save_cb = new ComboBox();
            label1 = new Label();
            saveSettings_btn = new Button();
            panel1 = new Panel();
            create_pbox = new PictureBox();
            plans_pbox = new PictureBox();
            home_pbox = new PictureBox();
            label2 = new Label();
            start_mips_cb = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)create_pbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plans_pbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)home_pbox).BeginInit();
            SuspendLayout();
            // 
            // file_save_cb
            // 
            file_save_cb.BackColor = Color.FromArgb(220, 221, 225);
            file_save_cb.FormattingEnabled = true;
            file_save_cb.Items.AddRange(new object[] { "Text", "XML" });
            file_save_cb.Location = new Point(279, 56);
            file_save_cb.Name = "file_save_cb";
            file_save_cb.Size = new Size(566, 23);
            file_save_cb.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 56);
            label1.Name = "label1";
            label1.Size = new Size(91, 18);
            label1.TabIndex = 1;
            label1.Text = "Save to File";
            // 
            // saveSettings_btn
            // 
            saveSettings_btn.AutoSize = true;
            saveSettings_btn.BackColor = Color.FromArgb(128, 19, 54);
            saveSettings_btn.FlatAppearance.BorderSize = 0;
            saveSettings_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(81, 10, 50);
            saveSettings_btn.FlatStyle = FlatStyle.Flat;
            saveSettings_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveSettings_btn.ForeColor = Color.White;
            saveSettings_btn.Location = new Point(812, 573);
            saveSettings_btn.Name = "saveSettings_btn";
            saveSettings_btn.Size = new Size(153, 28);
            saveSettings_btn.TabIndex = 15;
            saveSettings_btn.Text = "Save";
            saveSettings_btn.UseVisualStyleBackColor = false;
            saveSettings_btn.Click += saveSettings_btn_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(227, 233, 245);
            panel1.Controls.Add(create_pbox);
            panel1.Controls.Add(plans_pbox);
            panel1.Controls.Add(home_pbox);
            panel1.Location = new Point(0, 608);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 40);
            panel1.TabIndex = 16;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(120, 114);
            label2.Name = "label2";
            label2.Size = new Size(93, 18);
            label2.TabIndex = 17;
            label2.Text = "Start M.I.P.S";
            // 
            // start_mips_cb
            // 
            start_mips_cb.BackColor = Color.FromArgb(220, 221, 225);
            start_mips_cb.FormattingEnabled = true;
            start_mips_cb.Items.AddRange(new object[] { "Yes", "No" });
            start_mips_cb.Location = new Point(279, 109);
            start_mips_cb.Name = "start_mips_cb";
            start_mips_cb.Size = new Size(566, 23);
            start_mips_cb.TabIndex = 18;
            // 
            // pageSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(977, 644);
            Controls.Add(start_mips_cb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(saveSettings_btn);
            Controls.Add(label1);
            Controls.Add(file_save_cb);
            Name = "pageSettings";
            Text = "pageSettings";
            Load += pageSettings_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)create_pbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)plans_pbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)home_pbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox file_save_cb;
        private Label label1;
        private Button saveSettings_btn;
        private Panel panel1;
        private PictureBox create_pbox;
        private PictureBox plans_pbox;
        private PictureBox home_pbox;
        private Label label2;
        private ComboBox start_mips_cb;
    }
}