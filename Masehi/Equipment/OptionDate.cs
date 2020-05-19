using System;
using System.Collections.Generic;

namespace Masehi.Equipment
{
    class OptionDate
    {
        private const int dayLengthAsbuk = 7;
        private const int digit = 1;

        private static Dictionary<int, ConsoleColor> colorDate = new Dictionary<int, ConsoleColor>()
        {
            { 1, ConsoleColor.White}, { 2, ConsoleColor.White}, { 3, ConsoleColor.White},
            { 4, ConsoleColor.White}, { 5, ConsoleColor.Green}, { 6, ConsoleColor.White},
            { 7, ConsoleColor.Red}
        };

        private static Dictionary<int, ConsoleColor> colorDay = new Dictionary<int, ConsoleColor>()
        {
            { 1, ConsoleColor.Red}, { 2, ConsoleColor.White}, { 3, ConsoleColor.White},
            { 4, ConsoleColor.White}, { 5, ConsoleColor.White}, { 6, ConsoleColor.Green},
            { 7, ConsoleColor.White}
        };
        
        public static ConsoleColor DateColor(int dayLength)
        {
            return colorDate[dayLength];
        }

        public static ConsoleColor DayColor(int dayLength)
        {
            return colorDay[dayLength];
        }
        
        public static string GetNeatCalender(string value, int oneWeek, int digitNumber)
        {
            if ((oneWeek) == dayLengthAsbuk)
                Console.WriteLine("\n");

            value = Tools.GetDigit(digitNumber) == digit ? value.Insert(0, " ") : value;

            return oneWeek == dayLengthAsbuk ? value.Insert(0, "\t") : value;
        }
    }
}
