using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_C_Sharp
{
    internal class ForEachLoop
    {
        public static void ForEach()
        {
            int[] numbers = new int[] {1,2,3,4,5,6,7,8,9,10};
            string[] names = new string[] { "Noman", "Arshad", "Foysal", "Ashraf", "Sourav" };

            foreach(int item in  numbers)
            {
                Console.Write(item + " ");
            }
            
            Console.Write("\n");

            foreach (string name in names)
            {
                Console.Write($"{name} ");
            }

            Console.Write("\n");

        }
    }
}
