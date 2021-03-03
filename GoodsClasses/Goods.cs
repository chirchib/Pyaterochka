using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsClasses
{
    public abstract class Goods
    {
        private uint id;
        private string name;
        private double price;

        public uint ID
        {
            set
            {
                // ToDo: add checking id on repeat
                if (value > 0) id = value;
                else Console.WriteLine("ID have to be more 0");
            }
            get { return id; } 
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get { return name; }
        }

        public double Price
        {
            set
            {
                if (value > 0) price = value;
                else Console.WriteLine("Price have to be more 0");
            }
            get { return price; }
        }

        public Goods() { }
        public Goods(uint id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public virtual string Display()
        {
            return $"ID: {ID}, Name: {Name}, Price: {Price}$ ";
        }
    }
}
