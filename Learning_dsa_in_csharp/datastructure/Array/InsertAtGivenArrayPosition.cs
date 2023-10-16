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
            if (length > array.Length || position >= array.Length) return 404;

            for(int i = length; i>=position; i--)
            {
                array[i+1] = array[i];
            }

            array[position] = value;
            length++;

            Utility.DisplayArray(array);

            return length;
        }
    }
}
