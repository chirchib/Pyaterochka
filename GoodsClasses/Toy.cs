using System;

namespace GoodsClasses
{
    public class Toy : Goods
    {
        private string Type = "Toy";

        public Toy() { }
        public Toy(uint id, string name, double price) : base(id, name, price) { }


        public override string ToString()
        {
            return $"Type: {Type} ID: {ID}, Name: {Name}, Price: {Price}$ ";
        }
    }
}