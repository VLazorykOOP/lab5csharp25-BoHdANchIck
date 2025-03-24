using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Daneliuk.task_3
{
    class Toy : Product
    {
        public string Manufacturer { get; set; }
        public string Material { get; set; }
        public int AgeGroup { get; set; }

        public Toy(string name, decimal price, string manufacturer, string material, int ageGroup)
            : base(name, price)
        {
            Manufacturer = manufacturer;
            Material = material;
            AgeGroup = ageGroup;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Toy: {Name}, Price: {Price}, Manufacturer: {Manufacturer}, Material: {Material}, Age Group: {AgeGroup}+");
        }

        public override bool IsOfType(string type)
        {
            return type.ToLower() == "toy";
        }
    }
}
