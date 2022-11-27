using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Homunkulus
{
    public class custombutton : Button
    {
        private int Bordersize = 0;
        private int Borderradius = 40;
        private Color Bordercolor = Color.Pink;

        public custombutton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (Borderradius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, Borderradius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, Borderradius - 1F))
                using (Pen pensurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penborder = new Pen(Bordercolor, Bordersize))
                {
                    penborder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(pensurface, pathSurface);

                    if (Bordersize >= 1)
                    {
                        pevent.Graphics.DrawPath(penborder, pathSurface);
                    }
                    else
                    {
                        this.Region = new Region(rectSurface);

                        if (Bordersize >= 1)
                        {
                            using (Pen penborder2 = new Pen(Bordercolor, Bordersize))
                            {
                                penborder2.Alignment = PenAlignment.Inset;
                                pevent.Graphics.DrawRectangle(penborder2, 0, 0, this.Width - 1, this.Height - 1);
                            }
                        }
                    }
                }

            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChange);
        }

        private void Container_BackColorChange(object? sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
