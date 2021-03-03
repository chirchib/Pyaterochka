using GoodsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyaterochka
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Goods> goods = new List<Goods>();


            foreach(var item in goods)
            {
                item.Display();
            }

            Product milk = new milkProduct(10, "Bulka", 10.2, (21, 12, 3), (21, 12, 17));

            Goods bulka1 = new Product(10, "Bulka", 10.2, (21, 12, 3), (21, 12, 17));
            Product milk2 = new milkProduct(11, "Milk", 30.2, (21, 12, 3), (21, 12, 17));
            Goods ball = new Toy(12, "Ball", 300.0);

            milk.Display();

            Console.ReadKey();
        }
    }
}
