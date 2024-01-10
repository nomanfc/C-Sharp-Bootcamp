using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_csharp
{
    internal class ThreeSumAlgorithm_improvement
    {
        public static int ThreeSumImprovement(int[] array)
        {
            int count = 0;

            InsertionSortAlgorithm.InsertionSort(array);

            for (int i = 0; i < array.Length-2; i++)
            {
                for (int j = i + 1; j < array.Length-1; j++)
                {
                    int twoSum = -(array[i] + array[j]);

                    int res = BinarySearchAlgorithm.BinarySearch(array, twoSum);

                    if (res != -1 && res > j)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
