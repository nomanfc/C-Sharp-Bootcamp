using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class StringOperations
    {
        public static void Main()
        {
            // initialize
            string s1 = "Hello World";
            Console.WriteLine("s1 is \"" + s1 + "\"");
            string s2 = s1;
            Console.WriteLine("s2 is another reference to s1.");
            string s3 = new string(s1.ToCharArray());
            Console.WriteLine("s3 is a copy of s1.");

            // compare using '=='
            Console.WriteLine("Compared by '==':");
            // true since strings in C# are interned
            Console.WriteLine("s1 and \"Hello World\": " + (s1 == "Hello World")); // true
                                                                                   // true since s1 and s2 reference the same object
            Console.WriteLine("s1 and s2: " + (s1 == s2)); // true
                                                           // true since s3 refers to the same string object due to string interning
            Console.WriteLine("s1 and s3: " + (s1 == s3)); // true

            // compare using 'Equals'
            Console.WriteLine("Compared by 'Equals':");
            Console.WriteLine("s1 and \"Hello World\": " + s1.Equals("Hello World")); // true
            Console.WriteLine("s1 and s2: " + s1.Equals(s2)); // true
            Console.WriteLine("s1 and s3: " + s1.Equals(s3)); // true

            // compare using 'CompareTo'
            Console.WriteLine("Compared by 'CompareTo':");
            Console.WriteLine("s1 and \"Hello World\": " + (s1.CompareTo("Hello World") == 0)); // true
            Console.WriteLine("s1 and s2: " + (s1.CompareTo(s2) == 0)); // true
            Console.WriteLine("s1 and s3: " + (s1.CompareTo(s3) == 0)); // true
        }
    }
}
