using System;
using Masehi.Calender;

namespace Masehi.Equipment
{
    class Tools
    {
        const int minimalYear = 0;

        public static int GetDigit(int value)
        {
            return value.ToString().Length;
        }

        public static string GetText(string lable)
        {
            Colorful.WriteBackFore(lable, ConsoleColor.Black, ConsoleColor.Cyan);
            return Console.ReadLine();
        }

        public static int GetInputYear()
        {
            int number;
            while (true)
            {
                Console.Write("Input Year: ");
                string value = Console.ReadLine();

                bool checkTheTruth = int.TryParse(value, out number) && number > minimalYear;

                if (checkTheTruth)
                    return number;

                else
                    Console.WriteLine("Invalid Input!!!");
            }
        }
    }
}
