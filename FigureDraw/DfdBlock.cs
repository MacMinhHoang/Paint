using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class DfdStartBlock : StartBlock
    {
        public DfdStartBlock(ShapeInfo _info) : base(_info)
        {
            
        }

        public override void draw(CommonGraphics g)
        {
            g.drawString(info.points[0].X, info.points[0].Y, "1");
            g.drawEllipse(info.points[0].X - 20, info.points[0].Y - 16, 30, 30);
        }
    }

    class DfdInputBlock : InputBlock
    {
        public DfdInputBlock(ShapeInfo _info) : base(_info)
        {
            
        }

        public override void draw(CommonGraphics g)
        {
            int x1 = info.points[0].X,
                y1 = info.points[0].Y,
                x2 = x1,
                y2 = y1 - 80,
                x3 = x1 + 130,
                y3 = y1 - 80,
                x4 = x1 + 130,
                y4 = y1;

            g.drawLine(x1, y1, x2, y2);
            g.drawLine(x2, y2, x3, y3);
            g.drawLine(x3, y3, x4, y4);
            g.drawLine(x4, y4, x1, y1);
            g.drawLine(x1 + 15, y1, x2 + 15, y2);
            g.drawLine(x3 - 15, y3, x4 - 15, y4);
        }
    }
}
