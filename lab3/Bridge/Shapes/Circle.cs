using Rendering;
using System;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(ITypeDrawing impl) : base(impl) { }

        public override void Draw()
        {
            _impl.DrawCircle();
        }
    }
}
