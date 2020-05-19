using Masehi.Equipment;

namespace Masehi.Calender
{
    class Date
    {
        Limitation limitation;
        public int oneWeek;
        public int ahmus;

        private const int dayAhmusLengthLimit = 5;
        private const int dayAsbukLengthLimit = 7;

        public Date()
        {
            this.limitation = new Limitation();
        }

        private int GetFebruary(int year)
        {
            return Qoidah.LeapYear(year) ? 29 : 28;
        }

        private void PlaceDay1(WeekDay currentDay, int month, int year)
        {
            Day.DisplayDay();

            int ahmus = CurrentDay.Ahmus(month, year);
            for (int i = 1; i <= (int)currentDay; i++)
            {
                string symbol = currentDay == Day.GetWeekDay(i) ? $"\t 1 {Day.GetJavaDay(ahmus)}\t" : " \t";
                oneWeek = i;

                Colorful.WriteFore(symbol, OptionDate.DayColor(oneWeek));
            }
            this.ahmus = ahmus;
        }

        public void DisplayDate(int month, int year)
        {
            int[] limitDate = { 31, GetFebruary(year), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            PlaceDay1(CurrentDay.Asbuk(month, year), month, year);
            for (int day = 2; day <= limitDate[month - 1]; day++)
            {
                ahmus = limitation.DayLimit(ahmus, dayAhmusLengthLimit);

                string dayDisplay = $"{day} {Day.GetJavaDay(ahmus)}\t";
                Colorful.WriteFore(OptionDate.GetNeatCalender(dayDisplay, oneWeek, day), OptionDate.DateColor(oneWeek));

                oneWeek = limitation.DayLimit(oneWeek, dayAsbukLengthLimit);
            }
        }
    }
}
