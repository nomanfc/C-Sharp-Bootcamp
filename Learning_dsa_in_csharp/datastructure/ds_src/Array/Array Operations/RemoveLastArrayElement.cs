using Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations
{
    internal class RemoveLastArrayElement
    {
        public static int Main(int[] array, int length)
        {
            
            length--;

            Console.WriteLine("\nLast Element Has been Removed!");
            Utility.DisplayArray(array, length);

            return length;
        }
    }
}
