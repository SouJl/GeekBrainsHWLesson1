using System;


namespace GeekBrainsUtils
{
    public static class ConsoleExtension
    {
        public ConsoleExtension()         
        { }
        
        public void Print(this string str)
        {
            Console.WriteLine();
        }
    }
}
