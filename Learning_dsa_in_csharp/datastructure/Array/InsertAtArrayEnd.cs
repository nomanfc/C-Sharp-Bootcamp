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

            for(int i = 0; i < 3; i++)
            {
                array[length] = i;
                length++;
            }

            ArrayLength(array);
            DisplayArray(array);

            array[length] = 10;
            length++;
            array[length] = 100;
            length++;
            array[length] = 101;
            length++;

            ArrayLength(array);
            DisplayArray(array);
        }


        private static void DisplayArray(int[] array)
        {
            int i = 0; 
            Console.WriteLine("\nArray Elements: ");
            foreach (int element in array)
            {
                Console.WriteLine("Index " + i + " contains " + element);
                i++;
            }
        }

        private static int ArrayLength(int[] array)
        {
            Console.WriteLine("\nArray Length : " + array.Length);
            return array.Length;
        }
    }
}
