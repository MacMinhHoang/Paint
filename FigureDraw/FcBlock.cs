using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class FcStartBlock : StartBlock
    {
        public FcStartBlock(ShapeInfo _info) : base(_info)
        {
            
        }

        public override void draw(CommonGraphics g)
        {
            g.drawString(info.points[0].X, info.points[0].Y, "Start");
            g.drawEllipse(info.points[0].X - 30, info.points[0].Y - 20, 60, 30);
        }
    }

    class FcInputBlock : InputBlock
    {
        public FcInputBlock(ShapeInfo _info) : base(_info)
        {

        }

        public override void draw(CommonGraphics g)
        {
            int x1 = info.points[0].X,
                y1 = info.points[0].Y,
                x2 = x1 + 20,
                y2 = y1 - 80,
                x3 = x1 + 150,
                y3 = y1 - 80,
                x4 = x1 + 130,
                y4 = y1;

            g.drawLine(x1, y1, x2, y2);
            g.drawLine(x2, y2, x3, y3);
            g.drawLine(x3, y3, x4, y4);
            g.drawLine(x4, y4, x1, y1);
        }
    }
}
