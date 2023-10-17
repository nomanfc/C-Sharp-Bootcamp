using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class RemovegivenElementFromArray
    {
        public static void Main(int[] array, int value)
        {
            int count = 0;

            for(int i = 0; i<array.Length; i++)
            {
                if (array[i] != value)
                {
                    array[count] = array[i];
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
