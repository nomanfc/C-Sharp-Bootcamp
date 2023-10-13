using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_C_Sharp
{
    internal class Methods
    {
        //void methods
        public static void VoidMethod(string text)
        {
            Console.WriteLine($"Void Method: {text}");
        }

        //non-void method
        public static int IntMethod(int a, int b)
        {
            return a * b;
        }
    }
}
