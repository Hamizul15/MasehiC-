namespace Masehi.Equipment
{
    class Qoidah
    {
        public static bool LeapYear(int year)
        {
            return year % 4 == 0 ? true : false;
        }

        public int Asbuk(int year)
        {
            int tam = year - 1;
            int qoidah400 = (tam / 400) * 7;
            int qoidah100 = (tam % 400) / 100 * 5;
            int qoidah4 = (tam % 400) % 100 / 4 * 5;
            int sisa = (tam % 400) % 100 % 4;
            int qoidahTambah = (qoidah400 + qoidah100 + qoidah4 + sisa + 2) % 7;

            return qoidahTambah == 0 ? 7 : qoidahTambah;
        }

        public int Ahmus(int year)
        {
            int tam = year - 1;
            int qoidah400 = tam / 400 * 2;
            int qoidah100 = (tam % 400) / 100 * 4;
            int qoidah4 = (tam % 400) % 100 / 4 * 1;
            int sisa = (tam % 400) % 100 % 4 * 5;
            int qoidahTambah = (qoidah400 + qoidah100 + qoidah4 + sisa + 2) % 5;

            return qoidahTambah == 0 ? 5 : qoidahTambah;
        }
    }
}
