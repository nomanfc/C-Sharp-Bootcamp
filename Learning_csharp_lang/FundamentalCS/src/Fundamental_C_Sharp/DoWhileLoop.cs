using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_C_Sharp
{
    internal class DoWhileLoop
    {
        public static void DoWhile()
        {
            Console.WriteLine("This Loop will not END until user enter a WORD greater than 5...\n");

            string userInput;

            do
            {
                Console.WriteLine("Enter a Word: ");
                userInput = Console.ReadLine();
            } 
            while (userInput.Length < 5);


            Console.WriteLine("The do...while loop is finished..");
        }
    }
}
