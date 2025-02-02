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
            fileExtDropDown = new ComboBox();
            label1 = new Label();
            saveSettings_btn = new Button();
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
            fileExtDropDown.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            saveSettings_btn.Location = new Point(812, 604);
            saveSettings_btn.Name = "saveSettings_btn";
            saveSettings_btn.Size = new Size(153, 28);
            saveSettings_btn.TabIndex = 15;
            saveSettings_btn.Text = "Save";
            saveSettings_btn.UseVisualStyleBackColor = false;
            saveSettings_btn.Click += saveSettings_btn_Click;
            // 
            // pageSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(977, 644);
            Controls.Add(saveSettings_btn);
            Controls.Add(label1);
            Controls.Add(fileExtDropDown);
            Name = "pageSettings";
            Text = "pageSettings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox fileExtDropDown;
        private Label label1;
        private Button saveSettings_btn;
    }
}