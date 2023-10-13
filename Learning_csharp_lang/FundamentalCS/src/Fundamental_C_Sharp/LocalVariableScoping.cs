using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_C_Sharp
{
    internal class LocalVariableScoping
    {
        public static void ScopeTest()
        {
            var string_global = "I am var declared in ScopeTest Method and can be accessed from anywhere within this method";

            Console.WriteLine($"\nFrom ScopeTest Method block: {string_global}");

            if(5 > 0)
            {
                string string_local = "I am string declared in if block and I can be accessed from this if block only...";
                Console.WriteLine($"\nFrom IF Block: {string_global}");
                Console.WriteLine($"\nFrom IF Block: {string_local}");

                if (3 > 2)
                {
                    string nested_scope= "I am from nested if.";
                    Console.WriteLine(nested_scope);
                    Console.WriteLine($"\nFrom Nested IF Block: {string_global}");
                    Console.WriteLine($"\nFrom Nested IF Block: {string_local}");
                }
            }

        }
    }
}
