using Rendering;
using System;

namespace Shapes
{
    public abstract class Shape
    {
        protected ITypeDrawing _impl;

        protected Shape(ITypeDrawing impl)
        {
            _impl = impl;
        }

        public abstract void Draw();

        public void SetImpl(ITypeDrawing impl)
        {
            _impl = impl;
        }
    }
}
