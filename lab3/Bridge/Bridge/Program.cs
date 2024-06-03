using Rendering;
using Shapes;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ITypeDrawing raster = new Raster();
            ITypeDrawing vector = new Vector();

            Shape circle = new Circle(raster);
            Shape square = new Square(vector);
            Shape triangle = new Triangle(raster);

            circle.Draw();
            square.Draw();
            triangle.Draw();

            circle.SetImpl(vector);
            circle.Draw();
        }
    }
}
