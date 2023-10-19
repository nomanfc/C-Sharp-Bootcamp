using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class MoveZerosToEnd
    {
        public static void Main(int[] array)
        {
            int length = array.Length;

            int[] copyArray = new int[length];

            int j = 0;
            for(int i=0; i< array.Length; i++)
            {
                if (array[i] != 0)
                {
                    copyArray[j] = array[i];
                    j++;
                }
                else
                {
                    copyArray[length-1] = array[i];
                    length--;
                }
            }

            for(int i=0; i< array.Length; i++)
            {
                array[i] = copyArray[i];
            }

            Console.Write("Output: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
