using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Security.Permissions;

namespace BackupProgram_V2.Custom_Controlls
{
    internal class togglebutton:CheckBox
    {
        private Color OnBackColor = Color.FromArgb(250, 197, 63);
        private Color OnToggleColor = Color.FromArgb(253, 169, 32);
        private Color OffBackColor = Color.FromArgb(92, 92, 92);
        private Color OffToggleColor = Color.FromArgb(80, 80, 80);

        public togglebutton()
        {
            this.MinimumSize = new Size(30, 30);
        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize -2,0,arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)
            {
                pevent.Graphics.FillPath(new SolidBrush(OnBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(OnToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(OffBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(OffToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }

        }

    }
}
