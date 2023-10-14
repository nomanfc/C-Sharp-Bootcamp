using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_C_Sharp
{
    internal class WhileLoop
    {
        public static void UsingWhile()
        {
            int number = 0;

            while(number < 10)
            {
                Console.Write(number + " ");
                number++;
            }

            Console.WriteLine("\nWhile Loop is Finished...!!");
        }
    }
}
