using System;
using System.Collections.Generic;
using Masehi.Equipment;

namespace Masehi.Calender
{
    enum NameMonth
    {
        January = 1, February = 2, March = 3, April = 4,
        Mey = 5, June = 6, July = 7, August = 8, September = 9,
        October = 10, November = 11, December = 12
    }

    class Month
    {
        private Date date;

        public Month()
        {
            this.date = new Date();
        }

        private Dictionary<int, NameMonth> nameMonth = new Dictionary<int, NameMonth>()
        {
            { 1, NameMonth.January}, { 2, NameMonth.February}, { 3, NameMonth.March},
            { 4, NameMonth.April}, { 5, NameMonth.Mey}, { 6, NameMonth.June},
            { 7, NameMonth.July}, { 8, NameMonth.August}, { 9, NameMonth.September},
            { 10, NameMonth.October}, { 11, NameMonth.November}, { 12, NameMonth.December},
        };

        public void DisplayMonth(int year)
        {
            for (int month = 1; month <= (int)NameMonth.December; month++)
            {
                Colorful.WriteLineFore($"\n\n\n\t\t\t     {GetNameMonth(month)} {year}\n\n", ConsoleColor.White);
                date.DisplayDate(month, year);
            }
            Console.WriteLine("\n");
        }

        private NameMonth GetNameMonth(int monthIndex)
        {
            return nameMonth[monthIndex];
        }
    }
}
