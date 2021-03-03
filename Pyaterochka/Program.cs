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
            mainMenu();
        }

        static List<Goods> goods = new List<Goods>();

        static void mainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Display\n" +
                              "2. Add a new goods\n" +
                              "3. Delete a goods\n" +
                              "4. Exit");

            Console.WriteLine("Choice: ");
            char choice = Console.ReadKey(true).KeyChar;

            do
            {
                switch (choice)
                {
                    case '1':
                        DisplayMenu();
                        break;
                    case '2':
                        AddMenu();
                        break;
                    case '3':
                        DeleteMenu();
                        break;
                    case '4':
                        break;
                    default:
                        mainMenu();
                        break;
                }
            } while (choice != '4');
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Display all goods\n" +
                              "2. Display toys\n" +
                              "3. Display products\n" +
                              "4. Display milk products\n" +
                              "5. Back");

            Console.WriteLine("Choice: ");
            char choice = Console.ReadKey(true).KeyChar;

            do
            {
                switch (choice)
                {
                    case '1':
                        Console.Clear();
                        foreach (var item in goods)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;
                    case '2':
                        Console.Clear();
                        foreach (var item in goods)
                        {   
                            if (item.Type == "Toy")
                                Console.WriteLine(item.ToString());
                        }
                        break;
                    case '3':
                        Console.Clear();
                        foreach (var item in goods)
                        {
                            if (item.Type == "Product")
                                Console.WriteLine(item.ToString());
                        }
                        break;
                    case '4':
                        Console.Clear();
                        foreach (var item in goods)
                        {
                            if (item.Type == "Milk product")
                                Console.WriteLine(item.ToString());
                        }
                        break;
                    case '5':
                        mainMenu();
                        break;
                    default:
                        DisplayMenu();
                        break;
                } 
            } while (choice != '5');
        }

        static void AddMenu(bool ex = false)
        {
            Console.Clear();

            if (ex)
                Console.WriteLine("The good whis ID already exists.\nTry again");

            Console.WriteLine("1. Add a toy\n" +
                              "2. Add a product\n" +
                              "3. Add a milk product\n" +
                              "4. Back");

            Console.WriteLine("Choice: ");
            char choice = Console.ReadKey(true).KeyChar;

            do
            {
                switch (choice)
                {
                    case '1':
                        Console.Clear();
                        break;
                    case '2':
                        Console.Clear();
                        break;
                    case '3':
                        Console.Clear();
                        break;
                    case '4':
                        mainMenu();
                        break;
                    default:
                        AddMenu();
                        break;
                }
            } while (choice != '4');
        }

        static void DeleteMenu(bool ex = true)
        {
            Console.Clear();

            if (!ex)
                Console.WriteLine("There is no goods with this ID.\nTry again");

            Console.WriteLine("1. Delete a toy\n" +
                              "2. Delete a product\n" +
                              "3. Delete a milk product\n" +
                              "4. Back");

            Console.WriteLine("Choice: ");
            char choice = Console.ReadKey(true).KeyChar;

            do
            {
                switch (choice)
                {
                    case '1':
                        Console.Clear();
                        foreach (var item in goods)
                        {
                            if (item.Type == "Toy")
                                Console.WriteLine(item.ToString());
                        }

                        Console.WriteLine("Choice the ID of good that you want to delete");
                        int ID_toy = Convert.ToInt32(Console.ReadLine());

                        foreach (var item in goods)
                        {
                            if (item.ID == ID_toy)
                                goods.Remove(item);
                        }

                        DeleteMenu(isValidID(ID_toy));

                        break;
                    case '2':
                        Console.Clear();
                        foreach (var item in goods)
                        {
                            if (item.Type == "Product")
                                Console.WriteLine(item.ToString());
                        }

                        Console.WriteLine("Choice the ID of good that you want to delete");
                        int ID_prod = Convert.ToInt32(Console.ReadLine());

                        foreach (var item in goods)
                        {
                            if (item.ID == ID_prod)
                                goods.Remove(item);
                        }

                        DeleteMenu(isValidID(ID_prod));

                        break;
                    case '3':
                        Console.Clear();
                        foreach (var item in goods)
                        {
                            if (item.Type == "Milk product")
                                Console.WriteLine(item.ToString());
                        }

                        Console.WriteLine("Choice the ID of good that you want to delete");
                        int ID_milkprod = Convert.ToInt32(Console.ReadLine());

                        foreach (var item in goods)
                        {
                            if (item.ID == ID_milkprod)
                                goods.Remove(item);
                        }

                        DeleteMenu(isValidID(ID_milkprod));

                        break;
                    case '4':
                        mainMenu();
                        break;
                    default:
                        DeleteMenu();
                        break;
                }
            } while (choice != '4');
        }

        static bool isValidID(int id)
        {
            return goods.Exists(x => x.ID == id);
        }
    }
}
