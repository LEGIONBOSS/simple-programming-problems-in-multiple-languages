/*
Write a program that computes the sum of an alternating series where each element of the series is an expression of the form ((-1)^k+1)/(2*k-1) for each value of k from 1 to a million, multiplied by 4.
*/

/* Hint: This is a PI approximation*/

namespace _1._11_Sum_of_an_alternating_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int k = 1; k <= 1000000; k++)
            {
                sum += Math.Pow(-1, k + 1) / (2 * k - 1);
            }

            double result = 4 * sum;

            Console.WriteLine(result);
        }
    }
}
