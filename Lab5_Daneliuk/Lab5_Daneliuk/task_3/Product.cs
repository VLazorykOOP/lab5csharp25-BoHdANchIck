using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Daneliuk.task_3
{
    abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            Console.WriteLine($"{this.GetType().Name} constructor called");
        }

        public abstract void ShowInfo();

        public abstract bool IsOfType(string type);

        ~Product()
        {
            Console.WriteLine($"{this.GetType().Name} destructor called");
        }
    }
}
