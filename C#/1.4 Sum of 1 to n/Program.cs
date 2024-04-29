/*
Write a program that asks the user for a number n and prints the sum of the numbers 1 to n.
*/

namespace _1._4_Sum_of_1_to_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
