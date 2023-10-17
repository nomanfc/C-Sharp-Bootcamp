using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class InsertAtGivenArrayPosition
    {
        public static int Main(int[] array, int length, int position, int value)
        {
            if (length > array.Length || position-1 >= length) return length;

            for(int i = length; i>=position-1; i--)
            {
                array[i+1] = array[i];
            }

            array[position-1] = value;
            length++;

            Utility.DisplayArray(array, length);

            return length;
        }
    }
}
