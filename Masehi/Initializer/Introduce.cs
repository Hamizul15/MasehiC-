using System;
using Masehi.Equipment;

namespace Masehi.Initializer
{
    class Introduce
    {
        public static void Introduce_()
        {
            Console.Clear();

            Console.Title = "Calender Masehi";
            Colorful.WriteLineBackFore("Author: M.Madani H.F (2019)", ConsoleColor.Blue, ConsoleColor.White);
            Colorful.WriteLineBackFore($"Last Opened at: {DateTime.Now}\n", ConsoleColor.Black, ConsoleColor.Yellow);
        }
    }
}
