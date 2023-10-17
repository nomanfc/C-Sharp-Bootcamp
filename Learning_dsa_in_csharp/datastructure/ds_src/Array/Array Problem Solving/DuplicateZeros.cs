using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class DuplicateZeros
    {
        public static void DuplicateZero(int[] nums)
        {
            List<int> newArray = new();

            foreach (int i in nums)
            {
                if (i != 0)
                {
                    newArray.Add(i);
                }
                else
                {
                    newArray.Add(i);
                    newArray.Add(i);
                }
            }

            int[] resArray = newArray.ToArray();

            Array.Copy(resArray, nums, nums.Length);

            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
        }
    }
}
