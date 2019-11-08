using System;

namespace Homework3.Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("*\t");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + "\t");

                for (int j = 0; j < a.Length; j++)
                {
                    Console.Write(a[j] * b[i] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
