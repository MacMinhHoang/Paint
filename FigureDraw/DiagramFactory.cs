using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    abstract class DiagramFactory
    {
        public abstract StartBlock createStartBlock(ShapeInfo info);
        public abstract InputBlock createInputBlock(ShapeInfo info);
    }

    class FcFactory : DiagramFactory
    {
        public override InputBlock createInputBlock(ShapeInfo info)
        {
            return new FcInputBlock(info);
        }

        public override StartBlock createStartBlock(ShapeInfo info)
        {
            return new FcStartBlock(info);
        }
    }

    class DfdFactory : DiagramFactory
    {
        public override InputBlock createInputBlock(ShapeInfo info)
        {
            return new DfdInputBlock(info);
        }

        public override StartBlock createStartBlock(ShapeInfo info)
        {
            return new DfdStartBlock(info);
        }
    }

    class AcFactory : DiagramFactory
    {
        public override InputBlock createInputBlock(ShapeInfo info)
        {
            return new AcInputBlock(info);
        }

        public override StartBlock createStartBlock(ShapeInfo info)
        {
            return new AcStartBlock(info);
        }
    }
}
