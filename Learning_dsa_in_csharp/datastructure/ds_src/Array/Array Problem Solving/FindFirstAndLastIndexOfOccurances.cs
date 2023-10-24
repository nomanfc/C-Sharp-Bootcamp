using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class FindFirstAndLastIndexOfOccurances
    {
        public static void Main(int[] array, int target)
        {
            int firstIndex = FindFirstIndex(array, target);
            int lastIndex = FindLastIndex(array, target);

            int[] range = new int[] {firstIndex, lastIndex};

            Console.WriteLine($"First Index: {range[0]}\nLast  Index: {range[1]}");
        }

        private static int FindFirstIndex(int[] arr, int target)
        {
            int result = -1;
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int middleElement = left + (right - left) / 2;

                if (arr[middleElement] == target)
                {
                    result = middleElement;
                    right = middleElement - 1;
                }else if (arr[middleElement] < target)
                {
                    left = middleElement + 1;
                }
                else
                {
                    right = middleElement - 1;
                }

            }

            return result;
        }        
        
        private static int FindLastIndex(int[] arr, int target)
        {
            int result = -1;
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int middleElement = left + (right - left) / 2;
                
                if (arr[middleElement] == target)
                {
                    result = middleElement;
                    left = middleElement + 1;
                }
                else if (arr[middleElement] < target)
                {
                    left = middleElement + 1;
                }
                else
                {
                    right = middleElement - 1;
                }
            }

            return result;
        }
    }
}
