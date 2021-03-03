using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsClasses
{
    public class Goods
    {
        private uint ID;
        private string Name;
        private double Price;

        public Goods() { }
        public Goods(uint id, string name, double price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}$");
        }
    }
}
