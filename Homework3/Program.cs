using System;
using System.Collections.Generic;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<byte> ages = new List<byte>();

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Введите имя {0}: ", i);
                names.Add(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите возраст {0}: ", names[i]);
                byte age = Convert.ToByte(Console.ReadLine());
                ages.Add(age);
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("Имя: {0}, Возраст: {1}", names[i], ages[i]);
            }
            Console.ReadKey();
        }
    }
}
