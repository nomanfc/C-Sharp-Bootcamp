using Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations
{
    internal class RemoveFirstArrayElement
    {
        public static int Main(int[] array, int length)
        {
            for(int i = 1; i<length; i++)
            {
                array[i-1] = array[i];
            }

            length--;

            Utility.DisplayArray(array, length);

            return length;
        }
    }
}
