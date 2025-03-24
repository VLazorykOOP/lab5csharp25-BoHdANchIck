using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Daneliuk.task_2
{
    class Exam1 : Test1
    {
        public string Subject { get; set; }

        public Exam1() : base()
        {
            Subject = "Unknown";
            Console.WriteLine("Exam constructor (default) called");
        }

        public Exam1(string name, string subject) : base(name)
        {
            Subject = subject;
            Console.WriteLine("Exam constructor (name, subject) called");
        }

        public Exam1(string name, DateTime date, string subject) : base(name, date)
        {
            Subject = subject;
            Console.WriteLine("Exam constructor (name, date, subject) called");
        }

        ~Exam1()
        {
            Console.WriteLine("Exam destructor called");
        }

        public override void Show()
        {
            Console.WriteLine($"Exam: {Name}, Date: {Date.ToShortDateString()}, Subject: {Subject}");
        }
    }
}
