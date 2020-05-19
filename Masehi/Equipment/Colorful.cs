using System;

namespace Masehi.Equipment
{
    class Colorful
    {
        public static void WriteLineBack(string value, ConsoleColor consoleColor)
        {
            Console.BackgroundColor = consoleColor;
            Console.WriteLine(value);
        }

        public static void WriteBack(string value, ConsoleColor consoleColor)
        {
            Console.BackgroundColor = consoleColor;
            Console.Write(value);
        }

        public static void WriteLineFore(string value, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(value);
        }

        public static void WriteFore(string value, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.Write(value);
        }

        public static void WriteLineBackFore(string value, ConsoleColor consoleColorBack, ConsoleColor consoleColorFore)
        {
            Console.BackgroundColor = consoleColorBack;
            Console.ForegroundColor = consoleColorFore;
            Console.WriteLine(value);
        }

        public static void WriteBackFore(string value, ConsoleColor consoleColorBack, ConsoleColor consoleColorFore)
        {
            Console.BackgroundColor = consoleColorBack;
            Console.ForegroundColor = consoleColorFore;
            Console.Write(value);
        }
    }
}
