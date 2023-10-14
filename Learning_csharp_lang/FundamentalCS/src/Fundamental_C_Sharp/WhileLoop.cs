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
            int number = 1;
            var str = "a";

            while(number <= 9)
            {
                Console.Write(number + " ");
                number++;
                Console.WriteLine(str);
                str += "a";
            }
            Console.WriteLine("\nWhile Loop is Finished...!!");
        }
    }
}
