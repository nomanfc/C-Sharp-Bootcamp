using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSolvingTechnique
{
    internal class ReverseInteger
    {
        public static int Main(int number)
        {
            bool isNegative = number < 0;

            char[] chars = Math.Abs(number).ToString().ToCharArray(); 

            Array.Reverse(chars);

            int reversed = int.Parse(chars);

            return isNegative ? -reversed :  reversed;

        }
    }
}


//long reversed = 0;

//while (number > 0)
//{
//    long reminder = number % 10;
//    reversed = (reversed * 10) + reminder;
//    number = number / 10;
//}