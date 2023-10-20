using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts_with_chsarp
{
    internal class AddingValidationInConstructorParameter
    {
        const double Pi = 3.1416; //const must have assiged some value or it will show error. Dynamic value cannot be added in const

        public readonly int Height; // readonly used in constructor and asign of value not necessary
        public readonly int Width;

        public AddingValidationInConstructorParameter(int height, int width)
        {
            Height = GetLengthOfDefault(height, nameof(Height));
            Width = GetLengthOfDefault(width, nameof(Width));
        }

        private int GetLengthOfDefault(int length, string name)
        {
            int defaultValueOfNonPositive =  1;

            if(length <= 0)
            {
                Console.WriteLine($"{name} must be a positive number.");
                return defaultValueOfNonPositive;
            }

            return length;
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
