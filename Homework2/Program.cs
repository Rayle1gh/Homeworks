using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            Console.WriteLine("Введите первое число:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            y = Convert.ToDouble(Console.ReadLine());
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
