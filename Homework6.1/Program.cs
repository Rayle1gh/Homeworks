using System;

namespace Homework6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsWork = true;
            while (IsWork)
            {
                try
                {
                    Console.WriteLine("Введите положительное натуральное число не более 2 миллиардов(exit для выхода): ");
                    string str = Console.ReadLine();
                    if (str == "exit")
                        IsWork = false;
                    int i = 0;
                    int num = int.Parse(str);

                    if (num <= 0)
                    {
                        Console.WriteLine("Введено неверное значение! Попробуйте ещё раз: ");
                        continue;
                    }
                    foreach (char ch in str)
                    {
                        if ((int)ch % 2 == 0)
                        {
                            i++;
                        }
                    }
                    Console.WriteLine("В числе {0} - {1} четных цифр", num, i);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine($"Ошибка {e.GetType()}! Попробуйте ещё раз: ");
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Ошибка {e.GetType()}! Попробуйте ещё раз: ");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}