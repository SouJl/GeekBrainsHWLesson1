using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsLib
{
    public class ModifiedConsole
    {
        public static void Print(string str)
        {
            Console.WriteLine(str);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}
