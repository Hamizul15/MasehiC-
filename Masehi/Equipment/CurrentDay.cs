using Masehi.Calender;

namespace Masehi.Equipment
{
    class CurrentDay
    {
        private static Qoidah qoidah = new Qoidah();
        private static Nadzom nadzom = new Nadzom();

        private const int weekDayLenght = 7;
        private const int javaDayLenght = 5;


        public static WeekDay Asbuk(int month, int year)
        {
            int asbuk = qoidah.Asbuk(year) + nadzom.Asbuk(month, year);

            while (asbuk > weekDayLenght)
                asbuk -= weekDayLenght;

            return Day.GetWeekDay(asbuk);
        }

        public static int Ahmus(int month, int year)
        {
            int ahmus = qoidah.Ahmus(year) + nadzom.Ahmus(month, year);

            while (ahmus > javaDayLenght)
                ahmus -= javaDayLenght;

            return ahmus;

        }
    }
}
