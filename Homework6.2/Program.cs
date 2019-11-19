using System;

namespace Homework6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Clear();

                    double contribution = SetParam("Введите сумму первоначального взноса в рублях: ");
                    double percent = SetParam("Введите ежедневный процент дохода в виде десятичной дроби (1% = 0.01): ");
                    double result = SetResult(contribution);

                    PrintResultDays(contribution, percent, result);

                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void PrintResultDays(double contribution, double percent, double result)
        {
            int days = 0;

            while (contribution <= result)
            {
                contribution *= (percent + 1);
                days++;
            }

            Console.WriteLine($"Необходимое количество дней для накопления желаемой суммы: {days}");
        }

        private static double SetResult(double contribution)
        {
            while (true)
            {
                Console.Write("Введите желаемую сумму накопления в рублях: ");

                string input = Console.ReadLine();
                input = input.Replace('.', ',');

                if (double.TryParse(input, out double result))
                {
                    if (result > 0 && result > contribution)
                        return result;

                    if (result <= 0)
                    {
                        Console.WriteLine("Введите положительное значение!");
                    }
                    else if (result <= contribution)
                    {
                        Console.WriteLine("Сумма должна быть больше взноса!");
                    }
                }
                else
                    Console.WriteLine("Неверный формат");
            }
        }

        private static double SetParam(string text)
        {
            while (true)
            {
                Console.Write(text);

                string input = Console.ReadLine();
                input = input.Replace('.', ',');

                if (double.TryParse(input, out double param))
                {
                    if (param > 0)
                        return param;

                    Console.WriteLine("Введите положительное значение!");
                }
                else
                    Console.WriteLine("Неверный формат");
            }
        }
    }
}