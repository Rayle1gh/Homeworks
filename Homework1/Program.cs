using System;
using System.Threading;

namespace Homework1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine($"Привет, {name}!");
            Thread.Sleep(5000);
            Console.WriteLine("Пока, {0}", name);
            Console.ReadKey();
        }
    }
}
