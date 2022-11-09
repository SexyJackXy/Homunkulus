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
            this.create_btn = new System.Windows.Forms.Button();
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
            this.show_backup_btn.Location = new System.Drawing.Point(504, 558);
            this.show_backup_btn.Name = "show_backup_btn";
            this.show_backup_btn.Size = new System.Drawing.Size(234, 40);
            this.show_backup_btn.TabIndex = 2;
            this.show_backup_btn.Text = "Show Backups";
            this.show_backup_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(0, 605);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 40);
            this.panel1.TabIndex = 3;
            // 
            // create_btn
            // 
            this.create_btn.AutoSize = true;
            this.create_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.create_btn.FlatAppearance.BorderSize = 0;
            this.create_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.create_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_btn.ForeColor = System.Drawing.Color.White;
            this.create_btn.Location = new System.Drawing.Point(246, 558);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(234, 40);
            this.create_btn.TabIndex = 4;
            this.create_btn.Text = "Create Backup";
            this.create_btn.UseVisualStyleBackColor = false;
            // 
            // Landingpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 644);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.show_backup_btn);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Landingpage";
            this.Text = "Landingpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button show_backup_btn;
        private Panel panel1;
        private Button create_btn;
    }
}