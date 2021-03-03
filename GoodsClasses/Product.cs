using System;

namespace GoodsClasses
{
    public class Product : Goods
    {
        public Product() { }
        public Product(uint id, string name, double price) : base(id, name, price) { }
        
    }
}