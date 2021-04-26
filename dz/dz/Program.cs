using System;

namespace dz
{
    class Program
    {
        static void Main(string[] args)
        {

            string name1 = AskName();
            int age1 = AskAge();
            Console.WriteLine($" {name1} {age1}");
            string name2 = AskName();
            int age2 = AskAge();
            Console.WriteLine($" {name2} {age2}");
            Console.WriteLine("Кто старше?");
            string starwiy = Console.ReadLine();
            int c;
            int b;

            if (starwiy == name1 && age1 > age2)
            {
                c = age1 - age2;
                Console.WriteLine($"{name1} старше на {c} лет");
            }


            else if (starwiy == name1 && age1 < age2)
            {
                c = age2 - age1;
                Console.WriteLine($"Не верно {name1} младше на {c} лет");
            }


            else if (starwiy == name2 && age2 > age1)
            {
                b = age2 - age1;
                Console.WriteLine($"{name2} старше на {b} лет");
            }

            else if (starwiy == name2 && age2 < age1)
            {
                b = age1 - age2;
                Console.WriteLine($"Не верно { name2} младше на {b} лет");
            }



            Console.ReadKey();

        }
        static string AskName()
        {
            int test = 0;
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();



            while (Int32.TryParse(name, out test) || name.Trim().Length == 0)
            {
                Console.WriteLine("Введите корректное имя:");
                name = Console.ReadLine();
            }






            return name;






        }
        static int AskAge()
        {
            Console.WriteLine("Введите возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            while (age <= 0)
            {
                Console.WriteLine("Введите пожалуйста корректный возраст:");

                age = Convert.ToInt32(Console.ReadLine());

            }

            return age;




        }
    }
}
