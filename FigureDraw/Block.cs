using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    abstract class Block : Shape
    {
        public Block(ShapeInfo _info) : base(_info) { }
    }

    abstract class StartBlock : Block
    {
        public StartBlock(ShapeInfo _info) : base(_info) { }
    }

    abstract class InputBlock : Block
    {
        public InputBlock(ShapeInfo _info) : base(_info) { }
    }

    abstract class ProcessBlock : Block
    {
        public ProcessBlock(ShapeInfo _info) : base(_info) { }
    }

    abstract class OutputBlock : Block
    {
        public OutputBlock(ShapeInfo _info) : base(_info) { }
    }

    abstract class StepBlock : Block
    {
        public StepBlock(ShapeInfo _info) : base(_info) { }
    }

    abstract class ConditionBlock : Block
    {
        public ConditionBlock(ShapeInfo _info) : base(_info) { }
    }

    abstract class EndBlock : Block
    {
        public EndBlock(ShapeInfo _info) : base(_info) { }
    }
}
