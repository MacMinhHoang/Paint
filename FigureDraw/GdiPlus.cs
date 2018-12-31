using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class GdiPlus : CommonGraphics
    {
        private Graphics lib;

        public Pen pen { get; set; }
        public Font font { get; set; }
        public Brush brush { get; set; }

        public GdiPlus(Graphics graphics)
        {
            lib = graphics;
            pen = new Pen(Brushes.Black);
            pen.Width = 2;
            font = new Font("Arial", 16);
            brush = new SolidBrush(Color.Black);
        }

        public override void drawEllipse(int cx, int cy, int hradius, int vradius)
        {
            Rectangle rect = new Rectangle(cx, cy, hradius * 2, vradius * 2);
            lib.DrawEllipse(pen, rect);
        }

        public override void drawLine(int x1, int y1, int x2, int y2)
        {
            lib.DrawLine(pen, x1, y1, x2, y2);
        }

        public override void drawRectangle(int x, int y, int width, int height)
        {
            Rectangle rect = new Rectangle(x, y, width, height);
            lib.DrawRectangle(pen, rect);
        }

        public override void drawString(int x, int y, string s)
        {
            lib.DrawString(s, font, brush, x, y);
        }

        public override void fillRectangle(int x, int y, int width, int height, Color fillColor)
        {
            Rectangle rect = new Rectangle(x, y, width, height);
            lib.DrawRectangle(pen, rect);
            if (fillColor != null)
                lib.FillRectangle(new SolidBrush(fillColor), rect);
        }

        public override void fillEllipse(int cx, int cy, int hradius, int vradius, Color fillColor)
        {
            Rectangle rect = new Rectangle(cx, cy, hradius * 2, vradius * 2);
            lib.DrawEllipse(pen, rect);
            if (fillColor != null)
                lib.FillEllipse(new SolidBrush(fillColor), rect);
        }

        public override void setHighlightPen()
        {
            pen.Color = Color.Gray;
            pen.Width = 10;
        }

        public override void resetPen()
        {
            pen.Color = Color.Black;
            pen.Width = 2;
        }

        public override void drawRecShadow(int x, int y, int width, int height)
        {
            pen.Color = Color.Gray;
            pen.Width = 4;
            lib.DrawLine(pen, x + width + 3, y + 4, x + width + 3, y + height + 3);
            lib.DrawLine(pen, x + width + 3, y + height + 3, x + 4, y + height + 3);
            resetPen();
        }
    }
}

