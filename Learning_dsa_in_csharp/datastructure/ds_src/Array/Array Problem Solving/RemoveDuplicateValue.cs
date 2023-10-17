using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class RemoveDuplicateValue
    {
        public static void Main(int[] array)
        {

            int count = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != array[count-1])
                {
                    array[count] = array[i];
                    count++;
                }
            }

            for(int i = 0; i<count; i++)
            {
                Console.Write(array[i]+ " ");
            }

            //Console.WriteLine(count);
        }
    }
}
