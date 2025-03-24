using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Daneliuk.task_1
{
    class Exam : Test
    {
        public string Subject { get; set; }

        public Exam(string name, DateTime date, string subject)
            : base(name, date)
        {
            Subject = subject;
        }

        public override void Show()
        {
            Console.WriteLine($"Exam: {Name}, Date: {Date.ToShortDateString()}, Subject: {Subject}");
        }
    }
}
