using System;

namespace GoodsClasses
{
    public class milkProduct : Product
    {
        public milkProduct() { }
        public milkProduct(uint id, string name, double price) : base(id, name, price) { }
        public milkProduct(uint id, string name, double price,
                          (int, int, int) productionDate, (int, int, int) shelfLife) : base(id, name, price, productionDate, shelfLife) { }


        
    }

}