using Cairo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace FigureDraw
{
    public partial class Form1 : Form
    {
        const int LineLength = 100;
        const int RectWidth = 100;
        const int RectHeight = 100;
        const int RoundRadius = 50;

        List<Shape> shapes = new List<Shape>();
        Diagram diagram = new Diagram(new FcFactory());
        System.Drawing.Graphics g;
        CommonGraphics lib;
        Boolean isPainting = false;

        public Form1()
        {
            InitializeComponent();
            g = pnCanvas.CreateGraphics();
            lib = new GdiPlus(g);
        }

        private void pnCanvas_click(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            RadioButton checkedButton;
            Shape shape = null;
            if (pnShape.Enabled)
            {
                checkedButton = pnShape.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                switch (checkedButton.Text)
                {
                    case "Line":
                        shape = new Line(new ShapeInfo(point, new Point(e.X + LineLength, e.Y)));
                        break;
                    case "Rectangle":
                        shape = new Rect(new ShapeInfo(point, RectWidth, RectHeight));
                        break;
                    case "Round":
                        shape = new Round(new ShapeInfo(point, RoundRadius, RoundRadius));
                        break;
                    case "Star":
                        shape = new Star(new ShapeInfo(point));
                        break;
                }
            }
            else
            {
                checkedButton = pnBlock.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                switch (checkedButton.Text)
                {
                    case "Start":
                        shape = diagram.factory.createStartBlock(new ShapeInfo(point));
                        break;
                    case "Input":
                        shape = diagram.factory.createInputBlock(new ShapeInfo(point));
                        break;
                }
            }

            if (pnShape.Enabled)
            {
                if (cbHighlight.Checked)
                    shape = new HighlightShape(shape);
                if (cbShadow.Checked)
                    shape = new ShadowShape(shape);

                shapes.Add(shape);
            }
            else diagram.addBlock((Block)shape);
            isPainting = true;
            pnCanvas.Invalidate();
        }

        private void pnCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (isPainting)
            {
                foreach (Shape shape in shapes)
                    shape.draw(lib);
                diagram.draw(lib);
            }
        }

        private void pnCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + " : " + e.Y;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            diagram.clear();
            pnCanvas.Invalidate();
        }

        private void radioShape_CheckedChanged(object sender, EventArgs e)
        {
            pnDiagram.Enabled = !pnDiagram.Enabled;
            pnBlock.Enabled = !pnBlock.Enabled;
            pnShape.Enabled = !pnShape.Enabled;
            pnEffect.Enabled = !pnEffect.Enabled;
        }

        private void radioFcD_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
                diagram.convertFactory(new FcFactory());
            pnCanvas.Invalidate();
        }

        private void radioDfdD_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
                diagram.convertFactory(new DfdFactory());
            pnCanvas.Invalidate();
        }

        private void radioAcD_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
                diagram.convertFactory(new AcFactory());
            pnCanvas.Invalidate();
        }

        private void radioGdi_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
                lib = new GdiPlus(g);
            else
            {
                Surface s = new Win32Surface(g.GetHdc());
                Context c = new Context(s);
                lib = new Cairo(c);
            }
        }
    }
}
