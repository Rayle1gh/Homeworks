using System;

namespace Homework2.Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите первое число");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите операцию:");
                char oper = char.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double y = double.Parse(Console.ReadLine());
                double result;
                switch (oper)
                {
                    case '+':
                        result = Math.Round(x + y, 3);
                        Console.WriteLine("Сумма {0} и {1} равна {2}", x, y, result);
                        break;
                    case '-':
                        result = Math.Round(x - y, 3);
                        Console.WriteLine("Разница {0} и {1} равна {2}", x, y, result);
                        break;
                    case '*':
                        result = Math.Round(x * y, 3);
                        Console.WriteLine("Разница {0} и {1} равна {2}", x, y, result);
                        break;
                    case '/':
                        result = Math.Round(x / y, 3);
                        Console.WriteLine("Разница {0} и {1} равна {2}", x, y, result);
                        break;
                    case '%':
                        result = Math.Round(x % y, 3);
                        Console.WriteLine("Разница {0} и {1} равна {2}", x, y, result);
                        break;
                    case '^':
                        result = Math.Round(Math.Pow(x, y), 3);
                        Console.WriteLine("Разница {0} и {1} равна {2}", x, y, result);
                        break;
                    default:
                        Console.WriteLine("Неизвестный оператор");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
