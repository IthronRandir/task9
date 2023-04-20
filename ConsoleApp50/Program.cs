using System;

namespace ConsoleApp
{
    class Program
    {
        static void LeapYear(int year)
        {
            string yearStr = Convert.ToString(year);

            DateTime date1 = new DateTime(year, 01, 01);

            year++;

            DateTime date2 = new DateTime(year, 01, 01);

            int DaysInYear = (date2-date1).Days;
            bool b = DaysInYear == 366;

            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            int year = 2024;
            LeapYear(year);
        }
    }
}
