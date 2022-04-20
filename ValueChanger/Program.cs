using System;

namespace ValueChanger
{
    //Мельников Александр
    //Написать программу обмена значениями двух переменных
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Число b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            ChangeWithThirdMember(a, b);
            Console.WriteLine();
            ChangeWithoutThirdMember(a, b);
            Console.ReadKey();
        }

        //а) с использованием третьей переменной
        static void ChangeWithThirdMember(int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"Число a = {a}, число b = {b}");
        }

        //б) *без использования третьей переменной
        static void ChangeWithoutThirdMember(int a, int b)
        {
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine($" * Число a = {a}, число b = {b}");
        }
    }
}
