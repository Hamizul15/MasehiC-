using Masehi.Equipment;
using System;
using System.Collections.Generic;

namespace Masehi.Calender
{
    enum JavaDay
    {
        Lg = 1, Ph = 2, Pn = 3,
        Wg = 4, Kl = 5
    }

    enum WeekDay
    {
        Sun = 1, Mon = 2, Tue = 3, Wed = 4,
        Thu = 5, Fri = 6, Sat = 7
    }

    class Day
    {
        private static Dictionary<int, WeekDay> weekDay = new Dictionary<int, WeekDay>()
        {
            { 1, WeekDay.Sun}, { 2, WeekDay.Mon}, {3, WeekDay.Tue},
            { 4, WeekDay.Wed}, { 5, WeekDay.Thu}, { 6, WeekDay.Fri},
            { 7, WeekDay.Sat}
        };

        private static Dictionary<int, Enum> javaDay = new Dictionary<int, Enum>()
        {
            { 1, JavaDay.Lg}, { 2, JavaDay.Ph}, {3, JavaDay.Pn},
            { 4, JavaDay.Wg}, { 5, JavaDay.Kl}
        };

        public static void DisplayDay()
        {
            Console.Write("\t");
            for (int i = 1; i <= (int)WeekDay.Sat; i++)
            {
                Colorful.WriteFore($" {weekDay[i]}\t", OptionDate.DayColor(i));
            }
            Console.WriteLine("\n\n");
        }

        public static Enum GetJavaDay(int ahmus)
        {
            return javaDay[ahmus];
        }

        public static WeekDay GetWeekDay(int dayIndex)
        {
            return weekDay[dayIndex];
        }
    }
}
