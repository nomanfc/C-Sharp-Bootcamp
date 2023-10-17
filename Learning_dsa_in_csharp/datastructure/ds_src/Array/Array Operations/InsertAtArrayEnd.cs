using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class InsertAtArrayEnd
    {
        public static int Main(int[] array, int length, int value)
        {
            Console.WriteLine("\nInserting first five elements: ");

            for (int i = 0; i < 5; i++)
            {
                array[length] = i;
                length++;
            }

            array[length] = value;

            Utility.DisplayArray(array, length);

            return length;
        }
    }
}
