using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSolvingTechnique
{
    internal class StringReverse
    {
        public static void Main()
        {
            string st = "Hello World";

            char[] st2 = new char[st.Length];

            int j = 0;
            for(int i = st.Length - 1; i >= 0; i--)
            {
                st2[j] = st[i];
                j++;
            }

            Console.WriteLine("Input: " + st);
            Console.Write("Output: ");
            foreach (char c in st2)
            {
                Console.Write(c);
            }

        }
    }
}
