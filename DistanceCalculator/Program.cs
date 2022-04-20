using System;

namespace DistanceCalculator
{
    //Мельников Александр
    /*
     Написать программу, которая подсчитывает расстояние между точками с координатами x1,
    y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат,
    используя спецификатор формата .2f (с двумя знаками после запятой)
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("х1 = ");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            float y1 = float.Parse(Console.ReadLine());
            Console.Write("х2 = ");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            float y2 = float.Parse(Console.ReadLine());

            float r = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine();

            Console.WriteLine("Расстояние между точками = {0:F2}", r);

            Console.WriteLine();

            Console.WriteLine("Задание со *");
            Console.WriteLine("Расстояние между точками = {0:F2}", GetDistance(x1,y1,x2,y2));

            Console.ReadKey();
        }

        // Задание со *
        // Оформление вычисления расстояния между точками в виде метода
        static float GetDistance(float x1, float y1, float x2, float y2) 
            => (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}
