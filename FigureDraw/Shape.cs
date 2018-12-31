using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class ShapeInfo
    {
        public List<Point> points { get; set; }
        public int width { get; set; }
        public int height{ get; set; }

        public ShapeInfo(Point p)
        {
            points = new List<Point>();
            points.Add(p);
            width = height = 0;
        }

        public ShapeInfo(Point p1, Point p2)
        {
            points = new List<Point>();
            points.Add(p1);
            points.Add(p2);
            width = height = 0;
        }

        public ShapeInfo(Point p, int _width, int _heigth)
        {
            points = new List<Point>();
            points.Add(p);
            width = _width;
            height = _heigth;
        }
    }

    abstract class Shape
    {
        public ShapeInfo info { get; set; }
        public abstract void draw(CommonGraphics g);

        public Shape()
        {

        }

        public Shape(ShapeInfo _info)
        {
            info = _info;
        }
    }

    class Line : Shape
    {
        public Line(ShapeInfo _info) : base(_info)
        {
            
        }

        public override void draw(CommonGraphics g)
        {
            g.drawLine(info.points[0].X, info.points[0].Y, info.points[1].X, info.points[1].Y);
        }
    }

    class Rect : Shape
    {
        public Rect(ShapeInfo _info) : base(_info)
        {
           
        }

        public override void draw(CommonGraphics g)
        {
            g.drawRectangle(info.points[0].X, info.points[0].Y, info.width, info.height);
        }
    }

    class Star : Shape
    {
        public Star(ShapeInfo _info) : base(_info)
        {
        }

        public override void draw(CommonGraphics g)
        {
            int x1 = info.points[0].X,
                y1 = info.points[0].Y,
                x2 = x1 + 40,
                y2 = y1 - 100,
                x3 = x1 + 80,
                y3 = y1,
                x4 = x1 - 20,
                y4 = y1 - 60,
                x5 = x1 + 100,
                y5 = y1 - 60;
            g.drawLine(x1, y1, x2, y2);
            g.drawLine(x2, y2, x3, y3);
            g.drawLine(x3, y3, x4, y4);
            g.drawLine(x4, y4, x5, y5);
            g.drawLine(x5, y5, x1, y1);
        }
    }

    class Round : Shape
    {
        public Round(ShapeInfo _info) : base(_info)
        {

        }

        public override void draw(CommonGraphics g)
        {
            g.drawEllipse(info.points[0].X, info.points[0].Y, info.width, info.height);
        }
    }
}
