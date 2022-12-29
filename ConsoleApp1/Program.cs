using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            View view;
            view = new View();
            while (true)
            {
                view.viewMenu();
                Console.WriteLine();
                Console.WriteLine("Вийти з програми? '+'-Yes | '-'-No");
                if (Console.ReadLine() == "+")
                    break;
                Console.WriteLine();
            }
        }
    }
}
