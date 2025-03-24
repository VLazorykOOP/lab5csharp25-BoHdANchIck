using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Lab5_Daneliuk.task_2
{
    class FinalExam1 : Exam1
    {
        public bool IsGraduationExam { get; set; }

        public FinalExam1() : base()
        {
            IsGraduationExam = false;
            Console.WriteLine("FinalExam constructor (default) called");
        }

        public FinalExam1(string name, string subject, bool isGraduationExam) : base(name, subject)
        {
            IsGraduationExam = isGraduationExam;
            Console.WriteLine("FinalExam constructor (name, subject, isGraduationExam) called");
        }

        public FinalExam1(string name, DateTime date, string subject, bool isGraduationExam) : base(name, date, subject)
        {
            IsGraduationExam = isGraduationExam;
            Console.WriteLine("FinalExam constructor (name, date, subject, isGraduationExam) called");
        }

        ~FinalExam1()
        {
            Console.WriteLine("FinalExam destructor called");
        }

        public override void Show()
        {
            Console.WriteLine($"Final Exam: {Name}, Date: {Date.ToShortDateString()}, Subject: {Subject}, Graduation: {IsGraduationExam}");
        }
    }
}
