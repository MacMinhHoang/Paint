using Cairo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;

namespace FigureDraw
{
    class Cairo : CommonGraphics
    {
        public Context lib;

        public Cairo(Context context)
        {
            lib = context;
            lib.SetSourceRGB(1, 0, 0);
        }

        public override void drawEllipse(int cx, int cy, int hradius, int vradius)
        {
            //lib.NewSubPath();
            //lib.Scale(1, 0.7);
            lib.Arc(cx, cy, hradius, 0.0, 2.0 * Math.PI);
            //lib.Rectangle(cx, cy, hradius, vradius);
            //lib.MoveTo(cx, cy);
            //lib.LineTo(cx + 10, cy);
            lib.Stroke();
        }

        public override void drawLine(int x1, int y1, int x2, int y2)
        {
            lib.MoveTo(x1, y1);
            lib.LineTo(x2, y2);
            lib.Stroke();
        }

        public override void drawRecShadow(int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public override void drawRectangle(int x, int y, int width, int height)
        {
            lib.Rectangle(x, y, width, height);
            lib.Stroke();
        }

        public override void drawString(int x, int y, string s)
        {
            throw new NotImplementedException();
        }

        public override void fillEllipse(int cx, int cy, int hradius, int vradius, Color fillColor)
        {
            throw new NotImplementedException();
        }

        public override void fillRectangle(int x, int y, int width, int height, Color fillColor)
        {
            throw new NotImplementedException();
        }

        public override void resetPen()
        {
            throw new NotImplementedException();
        }

        public override void setHighlightPen()
        {
            throw new NotImplementedException();
        }
    }
}
