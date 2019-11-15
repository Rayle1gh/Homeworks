using System;

namespace Homework5
{
    class Program
    {
        enum Figures { Circle = 1, EquilateralTriangle, Rectangle }
        static void Main(string[] args)
        {
            bool IsWork = true;
            while (IsWork)
            {

                Console.Write("Введите тип фигуры(1-круг, 2-равносторонний треугольник, 3-прямоугольник, 4-выход): ");
                int numberOfFigures;
                if (!int.TryParse(Console.ReadLine(), out numberOfFigures))
                {
                    Console.WriteLine("Введено неверное значение!");
                    continue;
                }

                if (numberOfFigures == 4)
                    IsWork = false;

                double S, P;

                try
                {
                    Figures figure = (Figures)numberOfFigures;
                    switch (figure)
                    {
                        case Figures.Circle:
                            while (true)
                            {
                                Console.Write("Введите диаметр круга: ");
                                if (double.TryParse(Console.ReadLine(), out double d))
                                {
                                    if (d <= 0)
                                    {
                                        Console.WriteLine("Число должно быть положительным");
                                        continue;
                                    }
                                    S = Math.Round(Math.PI * Math.Pow(d, 2), 2);
                                    P = Math.Round(Math.PI * d, 2);
                                    Console.WriteLine($"Площадь поверхности: {S}");
                                    Console.WriteLine($"Длина периметра: {P}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                                }
                            }
                            break;
                        case Figures.EquilateralTriangle:
                            while (true)
                            {
                                Console.Write("Введите длину стороны треугольника: ");
                                if (double.TryParse(Console.ReadLine(), out double l))
                                {
                                    if (l <= 0)
                                    {
                                        Console.WriteLine("Число должно быть положительным");
                                        continue;
                                    }
                                    S = Math.Round((Math.Pow(l, 2) * Math.Sqrt(3)) / 4, 2);
                                    P = Math.Round(3 * l, 2);
                                    Console.WriteLine($"Площадь поверхности: {S}");
                                    Console.WriteLine($"Длина периметра: {P}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                                }
                            }
                            break;
                        case Figures.Rectangle:
                            while (true)
                            {
                                Console.WriteLine("Введите сначала длину, а затем высоту прямоугольника: ");
                                if (double.TryParse(Console.ReadLine(), out double w) && double.TryParse(Console.ReadLine(), out double h))
                                {
                                    if (w <= 0)
                                    {
                                        Console.WriteLine("Длина должна быть положительная");
                                        continue;
                                    }
                                    if (h <= 0)
                                    {
                                        Console.WriteLine("Высота должна быть положительная");
                                        continue;
                                    }
                                    S = Math.Round(2 * w * h, 2);
                                    P = Math.Round(2 * w + 2 * h, 2);
                                    Console.WriteLine($"Площадь поверхности: {S}");
                                    Console.WriteLine($"Длина периметра: {P}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                                }
                            }
                            break;
                        default:
                            throw new InvalidOperationException("Значение вне диапазона 1-4");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Непредвиденная ошибка: " + e.Message);
                }
            }
        }
    }
}