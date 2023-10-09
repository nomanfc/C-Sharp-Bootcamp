/*
 :::::::::::Boyer-Moore-Voting-Algorithm::::::::::
*
* This algorithm can select majority elements from an array with linear time complexity 
* and O(1) space complexity. 
* Majority elements are the elements which occerance is greater than ceiling(arraySize/2).
* 
* step1 : Select an element as candidate from array. For example: candidate = array[0];
* step2 : Take a count variable and assign value 1 to it;
* step3 : Traverse the array.
* step4 : Check if the cadidate element is equal to nums[i]. If they are equal increase 
*         count by 1, decrease other wise. Then check if the count value is 0. If count is 0 then 
*         Update candidate element to current element nums[i] and Set Count to 1.
* step5 : Varify if current candidate element occurs more than ceil(size/2) if it is greater return candidate element;
* step5 : return -1. that means no majority element in that array.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boyer_Moore_Voting_algo
{
    public class BoyerMoreVotingAlgo
    {
        public static int VotingAlgo(int[] nums)
        {
            int len = nums.Length;

            int candidate = nums[0];
            int count = 1;

            for(int i = 1; i<len; i++)
            {
                if(nums[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }

                if(count == 0)
                {
                    candidate = nums[i];
                    count = 1;
                }
            }

            count = 0;

            for(int i=0; i<len; i++)
            {
                if (nums[i] == candidate)
                {
                    count++;
                }
            }

            if(count > (len/2))
            {
                return candidate;
            }

            return -1;
        }
    }
}
