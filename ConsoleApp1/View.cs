using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class View
    {
        public double firstValue, secondValue;
        public string action;

        public void viewMenu()
        {   
            Console.WriteLine("Введiть число 1");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть число 2");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Виберiть операцiю: '+' '-' '*' '/'");
            action = Console.ReadLine();

            MathFunc mathFunc;
            mathFunc = new MathFunc();

            switch (action)
            {
                case "+":
                    Console.WriteLine(mathFunc.plus(firstValue, secondValue));
                    break;
                case "-":
                    Console.WriteLine(mathFunc.minus(firstValue, secondValue));
                    break;
                case "*":
                    Console.WriteLine(mathFunc.multipluy(firstValue, secondValue));
                    break;
                case "/":
                    if (secondValue == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(mathFunc.podelit(firstValue, secondValue));
                    break;
                default:
                    Console.WriteLine("Помилка, невiдоме число");
                    break;
            }
        }
    }
}
