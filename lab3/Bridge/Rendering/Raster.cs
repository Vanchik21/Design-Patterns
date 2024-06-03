using Rendering;
using System;

namespace Rendering
{
    public class Raster : ITypeDrawing
    {
        public void DrawCircle()
        {
            Console.WriteLine("Drawing Circle as pixels");
        }

        public void DrawSquare()
        {
            Console.WriteLine("Drawing Square as pixels");
        }

        public void DrawTriangle()
        {
            Console.WriteLine("Drawing Triangle as pixels");
        }
    }
}
