using System;

namespace Homework3.Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            int[] nums = new int[a];
            int[] numsTwo = new int[b];
            for (int i = 0; i < a; i++)
            {
                nums[i] = i + 1;
            }
            for (int i = 0; i < b; i++)
            {
                numsTwo[i] = i + 1;
            }
            Console.Write("*\t");
            for (int j = 1; j < numsTwo.Length; j++)
            {
                Console.Write(numsTwo[j] + "\t");
            }
            Console.WriteLine();
            for (int i = 1; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "\t");

                for (int j = 1; j < numsTwo.Length; j++)
                {
                    Console.Write(nums[i] * numsTwo[j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
