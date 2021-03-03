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

            Product milk = new milkProduct(10, "milk", 10.2, (21, 12, 3), (21, 12, 17));
            Goods bulka1 = new Product(10, "Bulka", 10.2, (21, 12, 3), (21, 12, 17));

            Goods ball = new Toy(12, "Ball", 300.0);

            
            goods.Add(ball);
            goods.Add(bulka1);
            goods.Add(milk);


            foreach (var item in goods)
            {
                Console.WriteLine(item.ToString());
            }


            Console.ReadKey();
        }
    }
}
