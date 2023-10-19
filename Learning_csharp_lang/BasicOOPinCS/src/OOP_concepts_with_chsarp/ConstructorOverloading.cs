using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts_with_chsarp
{
    internal class ConstructorOverloading
    {
        private string _patientName;
        private DateTime _date;

        public ConstructorOverloading(string name, DateTime date)
        {
            _patientName = name;
            _date = date;
        }


        public ConstructorOverloading(string patientName) : this(patientName, 7) { }

        public ConstructorOverloading(string patientNtname, int daysFromNow)
        {
            _patientName = patientNtname;
            _date = DateTime.Now.AddDays(daysFromNow);


            Printer.Print(this); //passing instance of current class
        }

        public DateTime GetDate() => _date;
        public string GetName() => _patientName;

        public void Display()
        {
            Console.WriteLine($"Name: {_patientName}\nVisit: {_date}");
        }

    }
}
