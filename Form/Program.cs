using System;

namespace Form
{
    //Мельников Александр
    /*
     Программа Анкета «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,
     рост, вес). В результате вся информация выводится в одну строчку.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Фамилия: ");
            string lastName = Console.ReadLine();
            Console.Write("Возраст: ");
            int  age = int.Parse(Console.ReadLine());
            Console.Write("Рост: ");
            float height = float.Parse(Console.ReadLine());
            Console.Write("Вес: ");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine();

            PrintWithGluing(firstName, lastName, age, height, weight);
            PrintWithFormat(firstName, lastName, age, height, weight);
            PrintWithSign(firstName, lastName, age, height, weight);

            Console.ReadKey();
        }

        static void PrintWithGluing(string firstName, string lastName, int age, float height, float weight)
        {
            Console.Write("Склеивание: ");
            Console.WriteLine(firstName + " " + 
                                lastName + " " + 
                                age + " " + 
                                height + " " + 
                                weight);
        }

        static void PrintWithFormat(string firstName, string lastName, int age, float height, float weight)
        {
            Console.Write("Форматирование: ");
            Console.WriteLine("{0} {1} {2} {3:F} {4:F}", firstName, lastName, age, height, weight);
        }
        
        static void PrintWithSign(string firstName, string lastName, int age, float height, float weight)
        {
            Console.Write("Использование $: ");
            Console.WriteLine($"{firstName} {lastName} {age} {height} {weight}");
        }
    }
}
