using System;

namespace GoodsClasses
{
    public class Product : Goods
    {
        private Date productionDate { get; }
        private Date shelfLife { get; }

        private string Type = "Product";

        public Product() { }
        public Product(uint id, string name, double price) : base(id, name, price) { }
        public Product(uint id, string name, double price, 
                      (int, int, int) productionDate, (int, int, int) shelfLife) : base(id, name, price) 
        {
            this.productionDate = new Date();
            this.productionDate.setDate(productionDate.Item1, productionDate.Item2, productionDate.Item3);

            this.shelfLife = new Date();
            this.shelfLife.setDate(shelfLife.Item1, shelfLife.Item2, shelfLife.Item3);
        }

        public override string Display()
        {
            return base.Display() + $"Prodaction date: {productionDate} Shelf Life: { shelfLife}";
        }

        public override string ToString()
        {
            return $"Type: {Type}, ID: {ID}, Name: {Name}, Price: {Price}$ Prodaction date: {productionDate} Shelf Life: { shelfLife}";
        }
    }

    class Date
    {
        private int years;
        private int months;
        private int days;


        public int Years 
        { 
            get
            {
                return years;
            }
            set
            {
                if (value > 0) years = value;
                else Console.WriteLine("Invalid value");
            }
        }
        public int Months
        {
            get
            {
                return months;
            }
            set
            {
                if ( value > 0 && value <= 12) months = value;
                else Console.WriteLine("Invalid value");
            }
        }
        public int Days
        {
            get
            {
                return days;
            }
            set
            {
                if (value > 0 && value <= 31) days = value;
                else Console.WriteLine("Invalid value");
            }
        }

        public Date() { }
        public Date((int, int, int) date)
        {
            setDate(date.Item1, date.Item2, date.Item3);
        }

        public void setDate(int years, int months, int days)
        {
            this.Years = years;
            this.Months = months;
            this.Days = days;
        }

        public override string ToString()
        {
            if ( Months < 10 && Days < 10) return $"{Years}:0{Months}:0{Days}";
            else if (Months < 10 && Days >= 10) return $"{Years}:0{Months}:{Days}";
            else if (Months >= 10 && Days < 10) return $"{Years}:{Months}:0{Days}";
            else return $"{Years}:{Months}:{Days}";
        }
    }
}