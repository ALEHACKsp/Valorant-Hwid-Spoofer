using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWID_Spoofer
{
    class Misc
    {
        private static int number;
        public static void DrawASCII()
        {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("M");
            Console.WriteLine("A");
            Console.WriteLine("M");
            Console.WriteLine("A");
            Console.WriteLine("E");
            Console.WriteLine("U");
            Console.WriteLine("P");
            Console.WriteLine("O");
            Console.WriteLine("H");
            Console.WriteLine("A");

     
   
        }
        public static void HashText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n[");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("#");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("] ");
            Console.Write(text);
        }

        public static void OptionText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n[");
            Console.ForegroundColor = ConsoleColor.White;
            number++;
            Console.Write(number);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("] ");
            Console.Write(text);
        }

        private static void ResetOption()
        {

            number = 0;

        }
    }


}
