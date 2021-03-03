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

            Goods bulka = new Goods(10, "Bulka", 10.2);
            Goods milk = new Goods(11, "Milk", 30.2);
            Goods cheese = new Goods(12, "Cheese", 50.3);

            goods.Add(bulka);
            goods.Add(milk);
            goods.Add(cheese);

            foreach(var item in goods)
            {
                item.Display();
            }


            Goods bulka1 = new Product(10, "Bulka", 10.2);
            Goods milk2 = new milkProduct(11, "Milk", 30.2);
            Goods ball = new Toy(12, "Ball", 300.0);

            ball.Display();

            Console.ReadKey();
        }
    }
}
