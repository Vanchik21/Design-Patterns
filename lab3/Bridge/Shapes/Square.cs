using Rendering;
using Shapes;
using System;

namespace Shapes
{
    public class Square : Shape
    {
        public Square(ITypeDrawing impl) : base(impl) { }

        public override void Draw()
        {
            _impl.DrawSquare();
        }
    }
}
