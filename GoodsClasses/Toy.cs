using System;

namespace GoodsClasses
{
    public class Toy : Goods
    {
        public Toy() { }
        public Toy(uint id, string name, double price) : base(id, name, price) { }
       
    }
}