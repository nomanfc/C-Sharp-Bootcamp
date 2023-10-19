using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts_with_chsarp
{
    internal class ExpressionBodiedMethod
    {
        public int Height;
        public int Width;

        public ExpressionBodiedMethod(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int CalculateArea() => Height * Width; //Method contains single expression or single statement can be written with Arrow symbol 

        public int CalculateCircumference() => 2 * Height + 2 * Width; //It is called Expression bodied method

    }
}
