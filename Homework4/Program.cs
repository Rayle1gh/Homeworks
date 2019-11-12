using System;

namespace Homework4
{
    class Program
    {
        public enum Months
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        public enum Seasons
        {
            Spring = 3,
            Summer = 6,
            Autumn = 9,
            Winter = 12
        }
        static void Main(string[] args)
        {

            Console.Write("Введите номер месяца: ");
            string number = (Console.ReadLine());
            int numberOfMonth;
            if (!int.TryParse(number, out numberOfMonth))
            {
                Console.WriteLine("Неверное значение");
                Console.ReadKey();
                return;
            }
            else if (numberOfMonth > 12)
            {
                Console.WriteLine("Месяца с таким номером НЕТ!");
                Console.ReadKey();
                return;
            }

            string name = Enum.GetName(typeof(Months), numberOfMonth);

            if (numberOfMonth >= (float)Seasons.Spring && numberOfMonth < (float)Seasons.Summer)
                name += ", Весна";
            else if (numberOfMonth >= (float)Seasons.Summer && numberOfMonth < (float)Seasons.Autumn)
                name += ", Лето";
            else if (numberOfMonth >= (float)Seasons.Autumn && numberOfMonth < (float)Seasons.Winter)
                name += ", Осень";
            else if
               (numberOfMonth == (float)Seasons.Winter || numberOfMonth < (float)Seasons.Spring)
                name += ", Зима";

            float quarter = 0;

            if (numberOfMonth % 3 == 0)
                quarter = numberOfMonth / 3;
            else
                quarter = numberOfMonth / 3 + 1;

            name += ", " + quarter + " Квартал";

            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
