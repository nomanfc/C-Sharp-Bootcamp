using Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations
{
    internal class RemoveFromGivenArrayPosition
    {
        public static int Main(int[] array, int length, int position)
        {
            if (length > array.Length || position >= length) return length;


            for(int i = position; i<length; i++)
            {
                array[i-1] = array[i];
            }

            length--;



            Utility.DisplayArray(array, length);

            return length;
        }
    }
}
