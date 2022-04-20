using System;
using GeekBrainsLib;

namespace IdWriter
{
    //Мельников Александр
    //Написать программу, которая выводит на экран ваше имя, фамилию и город проживания
    class Program
    {
        static void Main(string[] args)
        {
            //Задание а
            string str = "Мельников Александр г. Новосибирск";
            Console.WriteLine(str);
            
            Console.WriteLine();
            
            //Задание б
            Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.CursorTop);
            Console.WriteLine(str);

            //Задание в
            ConsoleCenter(str);

            ConsoleOnPos(str, (Console.WindowWidth - str.Length) / 2 , 20);

            ModifiedConsole.Pause();
        }

        /// <summary>
        /// Вывод в центр консоли
        /// </summary>
        /// <param name="str">отображаемая строка</param>
        static void ConsoleCenter(string str)
        {
             Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.WindowHeight / 2);
             Console.WriteLine(str);
        }

        /// <summary>
        /// Вывод в консоль по позиции
        /// </summary>
        /// <param name="str">отображаемая строка</param>
        /// <param name="x">координата х</param>
        /// <param name="y">координата y</param>
        static void ConsoleOnPos(string str, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(str);
        }
    }
}
