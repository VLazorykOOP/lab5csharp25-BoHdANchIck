using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Daneliuk.task_3
{
    class Book : Product
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int AgeGroup { get; set; }

        public Book(string name, decimal price, string author, string publisher, int ageGroup)
            : base(name, price)
        {
            Author = author;
            Publisher = publisher;
            AgeGroup = ageGroup;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Book: {Name}, Price: {Price}, Author: {Author}, Publisher: {Publisher}, Age Group: {AgeGroup}+");
        }

        public override bool IsOfType(string type)
        {
            return type.ToLower() == "book";
        }
    }
}
