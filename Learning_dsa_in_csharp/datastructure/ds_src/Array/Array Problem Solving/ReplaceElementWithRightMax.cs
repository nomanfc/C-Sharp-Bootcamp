using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class ReplaceElementWithRightMax
    {
        public static void Main(int[] arr)
        {
            int maxRight = -1;

            for(int i = arr.Length-1; i >= 0; i--)
            {
                int temp = arr[i];
                arr[i] = maxRight;

                if(temp > maxRight)
                {
                    maxRight = temp;
                }

            }

            Console.Write("Output: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
