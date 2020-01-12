using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double y = double.Parse(Console.ReadLine());
            var a = x + y;
            var b = x - y;
            var c = x * y;
            Console.WriteLine("Сумма чисел = {0}", a);
            Console.WriteLine("Разница чисел = {0}", b);
            Console.WriteLine("Произведение чисел = {0}", c);
            Console.ReadKey();
        }
    }
}
