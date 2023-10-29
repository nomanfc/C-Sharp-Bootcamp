using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts_with_chsarp
{
    internal class Properties
    {
        private int _height;
        private int _width;

        public Properties(int height, int width)
        {
            _height = height;
            _width = width;
        }

        
        public int Height
        {
            get
            {
                return _height;
            } 

            set
            {
                if(value > 0)
                {
                    _height = value;
                }

            }
        }

        public int GetWidth()
        {
            return _width;
        }
        public void SetWidth(int value)
        {
            if (value > 0)
            {
                _width = value;
            }
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
