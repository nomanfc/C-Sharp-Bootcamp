using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_C_Sharp
{
    internal class ParsingStringToInteger
    {
        public static void ParseStringToInt()
        {
            Console.Write("Enter a Number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            Console.WriteLine($"User input converted from string to integer. {number} is an integer here." );
        }
    }
}
