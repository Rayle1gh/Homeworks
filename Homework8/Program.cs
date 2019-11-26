using System;
using System.Collections.Generic;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите имя человека {i}");
                string name = Console.ReadLine();

            inputAge:
                Console.WriteLine($"Введите возраст {name}");

                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    var person = new Person
                    {
                        Name = name,
                        Age = age
                    };

                    people.Add(person);
                }
                else
                    goto inputAge;
            }
            people.ForEach((p) =>
            {
                Console.WriteLine(p.Result);
            });
            Console.ReadKey();
        }
    }

    class Person
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public int AgeIn4Years
        {
            get
            {
                return Age + 4;
            }
        }

        public string Result
        {
            get
            {
                return $"Имя: {Name}, Возраст через 4 года: {AgeIn4Years}";
            }
        }
    }
}