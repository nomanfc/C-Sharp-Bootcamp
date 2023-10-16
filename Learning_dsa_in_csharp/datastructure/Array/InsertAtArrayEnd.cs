using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class InsertAtArrayEnd
    {
        public static void Main(int[] array)
        {
            int length = 0;

            Console.WriteLine("\nInserting first three elements: \n");
            for (int i = 0; i < 3; i++)
            {
                array[length] = i;
                length++;
            }

            Utility.ArrayLength(array);
            Utility.DisplayArray(array);
        }
    }
}
