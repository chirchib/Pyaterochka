using System;

namespace GoodsClasses
{
    public class Toy : Goods
    {
        private int minAge = 0;
        private int maxAge = 0;

        public string Type => "Toy";

        public int MinAge
        {
            get
            {
                return minAge;
            }
            set
            {
                if (value >= 0 ) minAge = value;
                else Console.WriteLine("Invalid value");
            }
        }

        public int MaxAge
        {
            get
            {
                return minAge;
            }
            set
            {
                if (value >= 0) maxAge = value;
                else Console.WriteLine("Invalid value");
            }
        }

        public Toy() { }
        public Toy(int id, string name, double price) : base(id, name, price) { }
        public Toy(int id, string name, double price, int minAge, int maxAge = 0) : base(id, name, price)
        {
            this.MinAge = minAge;
            this.MaxAge = maxAge;
        }

        public override string ToString()
        {
            if (MaxAge == 0)
                return $"Type: {Type}, ID: {ID}, Name: {Name}, Price: {Price}$, {MinAge} to {MaxAge} years";
            else return $"Type: {Type}, ID: {ID}, Name: {Name}, Price: {Price}$, {MaxAge} & up years";
        }
    }
}