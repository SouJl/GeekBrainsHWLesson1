using System;

namespace BMI
{
    //Мельников Александр
    /*
      Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
      I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.     
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вес: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Рост: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Ваш ИМТ: " + GetBMI(weight, height));
            Console.ReadKey();
        }

        static float GetBMI(float height, float weight) =>  weight / (float)Math.Pow(height, 2); 
    }
}
