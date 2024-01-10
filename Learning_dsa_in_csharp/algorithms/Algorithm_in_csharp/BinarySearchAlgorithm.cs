using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_csharp
{
    internal class BinarySearchAlgorithm
    {
        public static int BinarySearch(int[] array, int key)
        {
            int high = array.Length - 1;
            int low = 0;

            while (low <= high)
            {
                int mid = low + ((high - low)/2);
                if (key < array[mid]) high = mid - 1;
                else if (key > array[mid]) low = mid + 1;
                else return mid;
            }

            return -1; 
        }
    }
}
