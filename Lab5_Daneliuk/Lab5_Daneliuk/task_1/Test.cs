using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Daneliuk.task_1
{
    class Test
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Test(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Test: {Name}, Data: {Date.ToShortDateString()}");
        }
    }
}
