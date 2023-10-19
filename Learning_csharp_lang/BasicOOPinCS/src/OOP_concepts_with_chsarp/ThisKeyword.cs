using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts_with_chsarp
{
    internal class Printer
    {
        public static void Print(ConstructorOverloading obj)
        {
            Console.WriteLine("\n:::::::::::::::::::::::::::::::::::Printed Copy::::::::::::::::::::::::::");
            Console.WriteLine($"Patient Name is {obj.GetName()}\nHis appoinment will Take Place on {obj.GetDate()}\n");
        }
    }
}
