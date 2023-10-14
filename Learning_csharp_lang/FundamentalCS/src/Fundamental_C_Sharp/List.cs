using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Fundamental_C_Sharp
{
    internal class List
    {
        public static void ListGeneric()
        {
            //List<string> nameList = new();
            var nameList = new List<string> { };

            DisplayNamesCount();

            string[] names = new string[] {"Abdullah Al Noman", "Asif Ul Islam", "Arshad Shahoriar", "Rafiqul Islam", "Tamim Iqbal", "Shakib Al Hasan" };

            foreach ( string name in names )
            {
                Console.WriteLine($"Inserting name: {name}");
                nameList.Add(name);
            }

            DisplayNamesCount();

            Console.WriteLine("Items In List : \n");
            foreach ( string item in nameList )
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            for (int  i = nameList.Count-1; i>=0; i--)
            {
                string item = nameList[i];

                if (item[0].Equals('A'))
                {
                    Console.WriteLine($"Removing Name: {nameList[i]}");
                    nameList.RemoveAt(i);
                }
            }

            DisplayNamesCount() ;    

            void DisplayNamesCount()
            {
                Console.WriteLine($"\nTotal Items: {nameList.Count}\n");
            }

        }
    }
}
