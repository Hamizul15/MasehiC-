namespace Masehi.Equipment
{
    class Limitation
    {
        public int DayLimit(int typeDay, int dayLengtLimit)
        {
            typeDay++;
            return typeDay > dayLengtLimit ? 1 : typeDay;  
        }
    }
}
