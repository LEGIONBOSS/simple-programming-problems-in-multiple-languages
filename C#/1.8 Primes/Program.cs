/*
Write a program that prints all prime numbers. (Note: if your programming language does not support arbitrary size numbers, printing all primes up to the largest number you can easily represent is fine too.)
*/

using System.Diagnostics;

namespace _1._8_Primes
{
    internal class Program
    {
        static int UpperLimit = 300;

        static bool IsPrime(int num)
        {
            if (num < 2 || num % 2 == 0)
            {
                return false;
            }

            int div = 2;
            while (div < num / 2 && num % div != 0)
            {
                div++;
            }
            return div >= num / 2;
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < UpperLimit; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
