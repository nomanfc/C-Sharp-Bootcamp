using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class FindPivotIndex
    {
        public static void Main(int[] array)
        {
            int total = 0;
            int leftSum = 0;
            int rightSum = 0;

            foreach (int i in array)
            {
                total += i;
            }

            for(int i = 0; i < array.Length; i++)
            {
                rightSum = total - leftSum - array[i];

                if(leftSum == rightSum)
                {
                    Console.WriteLine($"Pivot Index: {i}");
                    Console.WriteLine($"Pivot Element: {array[i]}");
                    return;
                }

                leftSum += array[i];
            }

            Console.WriteLine($"Pivot Index Not Found !!");
        }
    }
}
