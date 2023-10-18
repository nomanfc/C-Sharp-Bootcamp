using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts_with_chsarp
{
    internal class DateTimeStruct
    {
        public static void Main()
        {
            var InterNationalMotherLanguageDay = new DateTime(1952, 2, 21);

            Console.WriteLine($"International Mother Language Day is : {InterNationalMotherLanguageDay.Day}");
            Console.WriteLine($"International Mother Language Month is : {InterNationalMotherLanguageDay.Month}");
            Console.WriteLine($"International Mother Language Year is : {InterNationalMotherLanguageDay.Year}");
        }
    }
}
