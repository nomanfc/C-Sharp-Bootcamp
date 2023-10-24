using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class LargestNumberTwiceOfOthers
    {
        public static void Main(int[] nums)
        {
            int max = nums[0];
            int maxIndex = 0;
            int count = 1;

            for (int i = 1; i<nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIndex = i;
                   
                }
            }

            for(int i = 0; i < nums.Length; i++)
            {
                if (max >= (nums[i] * 2)) 
                { 
                    count++;
                }
            }

            if(count == nums.Length)
            {
                Console.WriteLine($"Max Index: {maxIndex}");
                Console.WriteLine($"Max Element: {max}");
            }
            else
            {
                Console.WriteLine("Max Element Not found in Array....!!!");
            }
        
        }
    }
}
