using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts_with_chsarp
{
    class Rectangle
    {
        public  int Height;
        public int Width;

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;  
        }

        public int CalculateArea()
        {
            return Height * Width;
        }

        public int CalculateCircumference()
        {
            return 2 * Height + 2 * Width;
        }
    }

}
