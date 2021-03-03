using System;

namespace GoodsClasses
{
    public class milkProduct : Goods
    {
        public milkProduct() { }
        public milkProduct(uint id, string name, double price) : base(id, name, price) { }
    }
}