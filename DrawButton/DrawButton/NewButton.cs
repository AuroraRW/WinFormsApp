using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace DrawButton
{
    public class NewButton:Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0,0,this.Width, this.Height);
            using (Brush gradientBrush = new LinearGradientBrush(rect, Color.Blue, Color.Green, 45F))
            {
                g.FillRectangle(gradientBrush, rect);
            }
             
            Font newFont = new Font("Arial", 12, FontStyle.Regular);
            TextRenderer.DrawText(g,"OK", newFont, rect,Color.White,TextFormatFlags.HorizontalCenter|TextFormatFlags.VerticalCenter);

            //Pen borderPen = new Pen(Color.Black, 15);
            //g.DrawRectangle(borderPen,rect);

            using (Pen highlightPen = new Pen(Color.White, 15))
            {
                g.DrawLine(highlightPen, 0, 0, this.Width, 0); // top
                g.DrawLine(highlightPen, 0, 0, 0, this.Height); // left
            }

            //highlightPen.Dispose();

            using (Pen shadowPen = new Pen(Color.DarkGray, 15))
            {
                g.DrawLine(shadowPen, this.Width, 0, this.Width, this.Height); // right
                g.DrawLine(shadowPen, 0, this.Height, this.Width, this.Height);// bottom
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.Size = new Size(this.Width + 10, this.Height + 10);
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            this.Size = new Size(this.Width - 10, this.Height - 10);
            base.OnMouseLeave(e);
        }
        protected override void OnResize(EventArgs e)
        {
            this.Width = this.Height;
            base.OnResize(e);
        }
    }
}
