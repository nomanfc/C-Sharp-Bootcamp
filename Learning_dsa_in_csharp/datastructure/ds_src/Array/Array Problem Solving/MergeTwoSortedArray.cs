using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class MergeTwoSortedArray
    {
        public static void MergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {
            int lastIndex = m + n - 1;
            int i = m - 1;
            int j = n - 1;

            while (j >= 0)
            {
                if(i>=0 && nums1[i] > nums2[j])
                {
                    nums1[lastIndex] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[lastIndex] = nums2[j];
                    j--;
                }

                lastIndex--;
            }

            Utility.Display(nums1);
        }
    }
}
