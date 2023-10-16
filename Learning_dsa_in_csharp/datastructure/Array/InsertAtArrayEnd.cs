using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class InsertAtArrayEnd
    {
        public static void Main()
        {
            int[] array = new int[6];
            int length = 0;

            Console.WriteLine("\nInserting first three elements: \n");
            for (int i = 0; i < 3; i++)
            {
                array[length] = i;
                length++;
            }

            Utility.ArrayLength(array);
            Utility.DisplayArray(array);

            Console.WriteLine("\nInserting last three elements: \n");
            array[length] = 10;
            length++;
            array[length] = 100;
            length++;
            array[length] = 101;

            Utility.ArrayLength(array);
            Utility.DisplayArray(array);
        }
    }
}
