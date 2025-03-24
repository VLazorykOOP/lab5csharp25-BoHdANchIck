using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Lab5_Daneliuk.task_1
{
    class Trial : Test
    {
        public string TypeOfTrial { get; set; }

        public Trial(string name, DateTime date, string typeOfTrial)
            : base(name, date)
        {
            TypeOfTrial = typeOfTrial;
        }

        public override void Show()
        {
            Console.WriteLine($"Test: {Name}, Date: {Date.ToShortDateString()}, Type: {TypeOfTrial}");
        }
    }
}
