using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class InsertAtArrayStart
    {
        public static int Main(int[] array, int length, int value)
        {
            for(int i = length; i >= 0; i--)
            {
                array[i+1] = array[i];
            }

            array[0] = value;
            length++;

            Utility.DisplayArray(array);

            return length;
        }
    }
}
