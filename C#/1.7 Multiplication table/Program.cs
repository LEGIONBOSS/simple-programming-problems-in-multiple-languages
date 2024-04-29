/*
Write a program that prints a multiplication table for numbers up to 12.
*/

namespace _1._7_Multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (i + j == 0) Console.Write(" ".PadLeft(4, ' '));
                    else if (i == 0) Console.Write(j.ToString().PadLeft(4, ' '));
                    else if (j == 0) Console.Write(i.ToString().PadLeft(4, ' '));
                    else Console.Write((i * j).ToString().PadLeft(4, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
