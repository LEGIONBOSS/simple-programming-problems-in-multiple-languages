/*
Write a function that tests whether a string is a palindrome.
*/

namespace _2._6_Palindrome
{
    internal class Program
    {
        static bool IsPalindrome(string s)
        {
            return s.ToLower() == String.Concat(s.ToLower().Reverse());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\tPalindrome?");
            Console.WriteLine("Hello\t" + IsPalindrome("Hello"));
            Console.WriteLine("TENET\t" + IsPalindrome("TENET"));
        }
    }
}
