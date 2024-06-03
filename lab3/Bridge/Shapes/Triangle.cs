using Rendering;
using Shapes;
using System;

namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(ITypeDrawing impl) : base(impl) { }

        public override void Draw()
        {
            _impl.DrawTriangle();
        }
    }
}
