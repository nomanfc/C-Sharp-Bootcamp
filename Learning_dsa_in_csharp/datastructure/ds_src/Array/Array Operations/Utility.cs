using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Utility
    {
        public static void DisplayArray(int[] array, int length)
        {
            int i = 0;
            Console.WriteLine("\nArray Elements: ");
            for(i = 0; i < length; i++)
            {
                Console.WriteLine("Index " + i + " contains " + array[i]);
            }
        }

        public static int ArrayLength(int[] array)
        {
            Console.WriteLine("Array Length : " + array.Length + "\n");
            return array.Length;
        }
    }
}
