using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Utility
    {
        public static void DisplayArray(int[] array)
        {
            int i = 0;
            Console.WriteLine("Array Elements: \n");
            foreach (int element in array)
            {
                Console.WriteLine("Index " + i + " contains " + element);
                i++;
            }
        }

        public static int ArrayLength(int[] array)
        {
            Console.WriteLine("Array Length : " + array.Length + "\n");
            return array.Length;
        }
    }
}
