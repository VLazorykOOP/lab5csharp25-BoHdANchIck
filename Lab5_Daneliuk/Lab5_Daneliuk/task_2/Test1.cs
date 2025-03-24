using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Daneliuk.task_2
{
    class Test1
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Test1()
        {
            Name = "Unknown";
            Date = DateTime.MinValue;
            Console.WriteLine("Test constructor (default) called");
        }

        public Test1(string name)
        {
            Name = name;
            Date = DateTime.MinValue;
            Console.WriteLine("Test constructor (name) called");
        }

        public Test1(string name, DateTime date)
        {
            Name = name;
            Date = date;
            Console.WriteLine("Test constructor (name, date) called");
        }

        ~Test1()
        {
            Console.WriteLine("Test destructor called");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Test: {Name}, Date: {Date.ToShortDateString()}");
        }
    }
}
