using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    class Diagram : Shape
    {
        private List<Block> blocks;
        public DiagramFactory factory { get; set; }

        public Diagram(DiagramFactory _factory)
        {
            factory = _factory;
            blocks = new List<Block>();
        }

        public void addBlock(Block block)
        {
            blocks.Add(block);
        }

        public override void draw(CommonGraphics g)
        {
            foreach (Block block in blocks)
                block.draw(g);
        }

        public void clear()
        {
            blocks.Clear();
        }

        public void convertFactory(DiagramFactory _factory)
        {
            factory = _factory;
            List<Block> newBlocks = new List<Block>();
            foreach(Block b in blocks)
            {
                if (b.GetType().IsSubclassOf(typeof(StartBlock)))
                    newBlocks.Add(factory.createStartBlock(b.info));
                else if (b.GetType().IsSubclassOf(typeof(InputBlock)))
                    newBlocks.Add(factory.createInputBlock(b.info));
            }
            blocks.Clear();
            blocks = newBlocks;
        }
    }
}
