using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Daneliuk.task_2
{
    class Trial1 : Test1
    {
        public string TypeOfTrial { get; set; }

        public Trial1() : base()
        {
            TypeOfTrial = "Unknown";
            Console.WriteLine("Trial constructor (default) called");
        }

        public Trial1(string name, string typeOfTrial) : base(name)
        {
            TypeOfTrial = typeOfTrial;
            Console.WriteLine("Trial constructor (name, typeOfTrial) called");
        }

        public Trial1(string name, DateTime date, string typeOfTrial) : base(name, date)
        {
            TypeOfTrial = typeOfTrial;
            Console.WriteLine("Trial constructor (name, date, typeOfTrial) called");
        }

        ~Trial1()
        {
            Console.WriteLine("Trial destructor called");
        }

        public override void Show()
        {
            Console.WriteLine($"Trial: {Name}, Date: {Date.ToShortDateString()}, Type: {TypeOfTrial}");
        }
    }
}
