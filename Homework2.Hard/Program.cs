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
                string firstNumber = Console.ReadLine();
                Console.WriteLine("Введите операцию:");
                string operation = Console.ReadLine();
                Console.WriteLine("Введите второе число");
                string secondNumber = Console.ReadLine();
                double x = double.Parse(firstNumber);
                double y = double.Parse(secondNumber);
                char oper = char.Parse(operation);
                double result;
                if (oper == '+')
                {
                    result = Math.Round(x + y, 3);
                    Console.WriteLine("Сумма {0} и {1} равна {2}", x, y, result);
                }
                else if (oper == '-')
                {
                    result = Math.Round(x - y, 3);
                    Console.WriteLine("Разница {0} и {1} равна {2}", x, y, result);
                }
                else if (oper == '*')
                {
                    result = Math.Round(x * y, 3);
                    Console.WriteLine("Произведение {0} и {1} равно {2}", x, y, result);
                }
                else if (oper == '/')
                {
                    result = Math.Round(x / y, 3);
                    Console.WriteLine("Частное {0} и {1} равно {2}", x, y, result);
                }
                else if (oper == '%')
                {
                    result = Math.Round(x % y, 3);
                    Console.WriteLine("Остаток от деления {0} и {1} равен {2}", x, y, result);
                }
                else if (oper == '^')
                {
                    result = Math.Round(Math.Pow(x, y), 3);
                    Console.WriteLine("Возведение {0} в степень {1} равно {2}", x, y, result);
                }
                else
                    Console.WriteLine("Неизвестный оператор");
                Console.ReadKey();

            }
        }
    }
}
