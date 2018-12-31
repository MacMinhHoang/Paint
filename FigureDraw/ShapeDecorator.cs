using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    abstract class ShapeDecorator : Shape
    {
        protected Shape coreShape;

        public ShapeDecorator(Shape shape)
        {
            coreShape = shape;
            info = shape.info;
        }
    }

    class HighlightShape : ShapeDecorator
    {
        public HighlightShape(Shape shape) : base(shape) { }

        public override void draw(CommonGraphics g)
        {
            g.setHighlightPen();
            coreShape.draw(g);
            g.resetPen();
        }
    }

    class ShadowShape : ShapeDecorator
    {
        public ShadowShape(Shape shape) : base(shape) { }

        public override void draw(CommonGraphics g)
        {
            int x = coreShape.info.points[0].X,
                y = coreShape.info.points[0].Y,
                width = coreShape.info.width,
                height = coreShape.info.height;
            coreShape.draw(g);
            if (coreShape.GetType() == typeof(Rect))
                g.drawRecShadow(x, y, width, height);
        }
    }
}
