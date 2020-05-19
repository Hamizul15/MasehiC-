using System;
using Masehi.Equipment;
using Masehi.Calender;

namespace Masehi.Initializer
{
    class Initializer_
    {
        Month month = new Month();
        
        public void UserOption()
        {
            Introduce.Introduce_();
            int year = Tools.GetInputYear();
            month.DisplayMonth(year);
        }
    }
}
