using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts_with_chsarp
{
    internal class AddingValidationInConstructorParameter
    {
        private int _height;
        private int _width;

        public AddingValidationInConstructorParameter(int height, int width)
        {
            _height = GetLengthOfDefault(height, nameof(_height));
            _width = GetLengthOfDefault(width, nameof(_width));
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
            return _height * _width;
        }

        public int CalculateCircumference()
        {
            return 2 * _height + 2 * _width;
        }

    }
}
