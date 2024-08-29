/*
Write a program that prints the next 20 leap years.
*/

namespace _1._10_Leap_years
{
    internal class Program
    {
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0)
                   ||
                   (year % 4 == 0 && year % 400 == 0);
        }

        static void Main(string[] args)
        {
            int checkedYear = (DateTime.Now.Year - (DateTime.Now.Year % 4)) + 4;
            int leapYears = 0;
            while (leapYears < 20)
            {
                if (IsLeapYear(checkedYear))
                {
                    Console.WriteLine(checkedYear);
                    leapYears++;
                }
                checkedYear += 4;
            }
        }
    }
}
