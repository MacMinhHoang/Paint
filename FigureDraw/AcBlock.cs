using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class AcStartBlock : StartBlock
    {
        public AcStartBlock(ShapeInfo _info) : base(_info)
        {
            
        }

        public override void draw(CommonGraphics g)
        {
            g.drawEllipse(info.points[0].X, info.points[0].Y, 20, 20);
            g.fillEllipse(info.points[0].X, info.points[0].Y, 20, 20, Color.Black);
        }
    }

    class AcInputBlock : InputBlock
    {
        public AcInputBlock(ShapeInfo _info) : base(_info)
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
                y4 = y1 - 10,
                x5 = x1 + 100,
                y5 = y1;

            g.drawLine(x1, y1, x2, y2);
            g.drawLine(x2, y2, x3, y3);
            g.drawLine(x3, y3, x4, y4);
            g.drawLine(x4, y4, x5, y5);
            g.drawLine(x5, y5, x1, y1);
        }
    }
}
