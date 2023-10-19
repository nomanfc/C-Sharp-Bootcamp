using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class HeightChecking
    {
        public static void Main(int[] heights)
        {
            int[] expArr = new int[heights.Length];

            for (int i = 0; i < heights.Length; i++)
            {

                expArr[i] = heights[i];
            }

            Array.Sort(expArr);

            int count = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if (expArr[i] != heights[i])
                {
                    count++;
                }
            }

            Console.Write("Expctd: ");
            foreach(int i in expArr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine($"\nMismatch in {count} places...");
        }
    }
}
