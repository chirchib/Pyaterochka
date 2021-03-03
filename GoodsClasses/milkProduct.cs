using System;

namespace GoodsClasses
{
    public class milkProduct : Product
    {
        private Date productionDate;
        private Date shelfLife;

        public string Type => "Milk product";

        public milkProduct() { }
        public milkProduct(int id, string name, double price) : base(id, name, price) { }
        public milkProduct(int id, string name, double price,
                          (int, int, int) productionDate, (int, int, int) shelfLife) : base(id, name, price, productionDate, shelfLife)
        {
            this.productionDate = new Date(productionDate);
            this.shelfLife = new Date(shelfLife);
        }

        public override string ToString()
        {
            return $"Type: {Type}, ID: {ID}, Name: {Name}, Price: {Price}$ Prodaction date: {productionDate} Shelf Life: {shelfLife}";
        }

    }

}