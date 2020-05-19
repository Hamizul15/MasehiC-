using System.Collections.Generic;

namespace Masehi.Equipment
{
    class Nadzom
    {
        private Dictionary<int, int> asbukBhasitoh = new Dictionary<int, int>()
        {
            { 1, 0}, { 2, 3},{ 3, 3}, { 4, 6},{ 5, 1},{ 6, 4},
            { 7, 6},{ 8, 2},{ 9, 5},{ 10, 7},{11, 3}, {12, 5},
        };

        private Dictionary<int, int> asbukKabisat = new Dictionary<int, int>()
        {
            { 1, 0}, { 2, 3}, { 3, 4}, { 4, 0}, { 5, 2}, { 6, 5},
            { 7, 0},{ 8, 3},{ 9, 6},{ 10, 1},{11, 4},{12, 6},
        };

        private Dictionary<int, int> ahmusKabisat = new Dictionary<int, int>()
        {
            { 1, 0}, { 2, 1},{ 3, 0}, { 4, 1}, { 5, 1},{ 6, 2},
            { 7, 2},{ 8, 3},{ 9, 4},{ 10, 4},{11, 5}, {12, 0},
        };

        private Dictionary<int, int> ahmusBhasitoh = new Dictionary<int, int>()
        {
            { 1, 0}, { 2, 1}, { 3, 4}, { 4, 0}, { 5, 0},{ 6, 1},
            { 7, 1},{ 8, 2},{ 9, 8},{ 10, 8},{11, 4}, {12, 4},
        };

        public int Asbuk(int month, int year)
        {
            return Qoidah.LeapYear(year) ? asbukKabisat[month] : asbukBhasitoh[month];
        }

        public int Ahmus(int month, int year)
        {
            return Qoidah.LeapYear(year) ? ahmusKabisat[month] : ahmusBhasitoh[month];
        }
    }
}