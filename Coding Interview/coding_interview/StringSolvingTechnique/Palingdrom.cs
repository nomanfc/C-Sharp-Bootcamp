using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSolvingTechnique
{
    internal class Palingdrom
    {
        public static bool Main(string input)
        {

            int left = 0;
            int right = input.Length-1;

            while(left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
