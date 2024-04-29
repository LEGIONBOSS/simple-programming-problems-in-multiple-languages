/*
Write a program that asks the user for a number n and gives them the possibility to choose between computing the sum and computing the product of 1,...,n
*/

namespace _1._6_Sum_or_product_of_1_to_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("(S)um or (P)roduct: ");
            string s = Console.ReadLine();

            if (s.ToLower().Trim().StartsWith('s'))
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                int product = 1;
                for (int i = 1; i <= n; i++)
                {
                    product *= i;
                }
                Console.WriteLine("Product = " + product);
            }
        }
    }
}
