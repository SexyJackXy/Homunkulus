﻿namespace Homunkulus
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
            fileExtDropDown = new ComboBox();
            label1 = new Label();
            saveSettings_btn = new Button();
            panel1 = new Panel();
            create_pbox = new PictureBox();
            plans_pbox = new PictureBox();
            home_pbox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)create_pbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plans_pbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)home_pbox).BeginInit();
            SuspendLayout();
            // 
            // fileExtDropDown
            // 
            fileExtDropDown.BackColor = Color.FromArgb(220, 221, 225);
            fileExtDropDown.FormattingEnabled = true;
            fileExtDropDown.Items.AddRange(new object[] { "Text", "XML" });
            fileExtDropDown.Location = new Point(128, 56);
            fileExtDropDown.Name = "fileExtDropDown";
            fileExtDropDown.Size = new Size(681, 23);
            fileExtDropDown.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(128, 35);
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
            // pageSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(977, 644);
            Controls.Add(panel1);
            Controls.Add(saveSettings_btn);
            Controls.Add(label1);
            Controls.Add(fileExtDropDown);
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

        private ComboBox fileExtDropDown;
        private Label label1;
        private Button saveSettings_btn;
        private Panel panel1;
        private PictureBox create_pbox;
        private PictureBox plans_pbox;
        private PictureBox home_pbox;
    }
}