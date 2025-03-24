using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Daneliuk.task_1
{
    class FinalExam : Exam
    {
        public bool IsGraduationExam { get; set; }

        public FinalExam(string name, DateTime date, string subject, bool isGraduationExam)
            : base(name, date, subject)
        {
            IsGraduationExam = isGraduationExam;
        }

        public override void Show()
        {
            Console.WriteLine($"Final exam: {Name}, Date: {Date.ToShortDateString()}, Subject: {Subject}, Graduation: {IsGraduationExam}");
        }
    }
}
