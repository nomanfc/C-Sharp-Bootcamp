using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_C_Sharp
{
    internal class OutKeyword
    {
        public static void Out()
        {
            int[] nums = new int[] { 10,20,30,40,5,-1,-50,-41,-40};


            var positive = GetPositiveNumbers(nums, out int nonPositiveValue); //we can return two values using out keyword

            Console.WriteLine($"\nNo. of Negative Value: {nonPositiveValue}\n");

            Console.Write("Positive Values: ");
            foreach (int PositiveNums in positive)
            {
                Console.Write(PositiveNums +" ");
            }

            Console.WriteLine("\n");

            static List<int> GetPositiveNumbers(int[] numbers, out int nonPositiveValue)
            {
                var numbersList = new List<int>();
                
                nonPositiveValue = 0;

                foreach (int number in numbers)
                {
                    if(number >= 0)
                    {
                        numbersList.Add(number);
                    }
                    else
                    {
                        nonPositiveValue++;
                    }
                }

                return numbersList;
            }
        }
    }
}
