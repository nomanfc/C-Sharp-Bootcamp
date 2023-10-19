using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts_with_chsarp
{
    class MethodOverloading
    {
        private string _name;
        private DateTime _date;

        public MethodOverloading(string name, DateTime date)
        {
            _name = name;
            _date = date;
        }

        public void ReSchedule(DateTime date)
        {
            _date = date;
        }

        public void ReSchedule(int month,  int day)
        {
            _date = new DateTime(_date.Year, month, day);   
        }

        public void Display()
        {
            Console.WriteLine($"Patient Name: {_name}\nVisiting Date: {_date}");
        }

    }
}
