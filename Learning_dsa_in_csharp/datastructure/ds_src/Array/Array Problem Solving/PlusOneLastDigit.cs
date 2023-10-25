using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class PlusOneLastDigit
    {
        public static int[] Main(int[] digits)
        {
            Console.Write($"After Plus One: ");

            for (int i=digits.Length-1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i] = digits[i] + 1;

                    return digits;
                }

                digits[i] = 0;
            }


            int[] result = new int[digits.Length+1];
            result[0] = 1;

            return result;


        }
    }
}
