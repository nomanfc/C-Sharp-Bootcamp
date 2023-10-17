using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    public class Utility
    {
        public static void Display(int[] array)
        {
            Console.Write("Output: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
