using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab5_Daneliuk.task_3
{
    class SportsEquipment : Product
    {
        public string Manufacturer { get; set; }
        public int AgeGroup { get; set; }

        public SportsEquipment(string name, decimal price, string manufacturer, int ageGroup)
            : base(name, price)
        {
            Manufacturer = manufacturer;
            AgeGroup = ageGroup;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Sports Equipment: {Name}, Price: {Price}, Manufacturer: {Manufacturer}, Age Group: {AgeGroup}+");
        }

        public override bool IsOfType(string type)
        {
            return type.ToLower() == "sports equipment";
        }
    }
}
