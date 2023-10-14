using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_C_Sharp
{
    internal class TryParseMethod
    {
        public static void TryParseM()
        {
            bool isParsingSuccessful;

            do
            {
                Console.WriteLine("\nEnter a Number: ");
                var userInput = Console.ReadLine();

                isParsingSuccessful = int.TryParse(userInput, out int number);

                if (isParsingSuccessful)
                {
                    Console.WriteLine($"\nParsing successful. The Number is: {number}");
                }
                else
                {
                    Console.WriteLine("\nParsing Unsuccessful.");
                }
            }while(!isParsingSuccessful);   

        }
    }
}
