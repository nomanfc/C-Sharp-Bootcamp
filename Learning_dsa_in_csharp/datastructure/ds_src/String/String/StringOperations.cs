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
            string s1 = "hello_word_s1";
            Console.WriteLine($"s1 is : {s1}");

            string s2 = s1;
            Console.WriteLine("\nstring s2 = s1: s2 is another reference to s1.");
            Console.WriteLine($"s2 is : {s2}");

            string s3 = new string(s2);
            Console.WriteLine($"\nstring s3 = new string(s2): s3 is a copy of s1.");
            Console.WriteLine($"s3 is : {s3}");

            Console.WriteLine("\nComparing using '==' operator:");
            Console.WriteLine($"s1 == s2 : {s1 == s2}");
        }
    }
}
