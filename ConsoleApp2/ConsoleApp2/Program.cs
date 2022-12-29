using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Виберiть пункт меню:");
                Console.WriteLine("1 - Додати товар");
                Console.WriteLine("2 - Переглянути товари");
                Console.WriteLine("3 - Видалити товар");
                Console.WriteLine("4 - Закрити програму");
                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            Console.WriteLine("Введiть назву товару:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введiть опис товару");
                            string descrp = Console.ReadLine();
                            Console.WriteLine("Введiть цiну товару");
                            int cost = int.Parse(Console.ReadLine());
                            Goods goods = new Goods(name, descrp, cost);
                            storage.addGoods(goods);
                            break;
                        }
                    case 2:
                        {
                            storage.listGoods();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введiть назву товару для видалення:");
                            string name = Console.ReadLine();
                            storage.deleteGoods(storage.findGoods(name));
                            break;
                        }
                    case 4:
                        {
                            exit = false;
                            break;
                        }
                    default:
                        break;
                }     
            }
        }
    }
}
