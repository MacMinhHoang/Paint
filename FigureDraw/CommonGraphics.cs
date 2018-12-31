using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FigureDraw
{
    abstract class CommonGraphics
    {
        public abstract void drawLine(int x1, int y1, int x2, int y2);
        public abstract void drawRectangle(int x, int y, int width, int height);
        public abstract void drawEllipse(int cx, int cy, int hradius, int vradius);
        public abstract void drawString(int x, int y, string s);

        public abstract void fillRectangle(int x, int y, int width, int height, Color fillColor);
        public abstract void fillEllipse(int cx, int cy, int hradius, int vradius, Color fillColor);

        public abstract void setHighlightPen();
        public abstract void resetPen();

        public abstract void drawRecShadow(int x, int y, int width, int height);
    }
}
