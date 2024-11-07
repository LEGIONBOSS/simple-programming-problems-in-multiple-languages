/*
Write a function on_all that applies a function to every element of a list. Use it to print the first twenty perfect squares. The perfect squares can be found by multiplying each natural number with itself. The first few perfect squares are 1*1=1, 2*2=4, 3*3=9, 4*4=16. Twelve for example is not a perfect square because there is no natural number m so that m*m=12. (This question is tricky if your programming language makes it difficult to pass functions as arguments.)
*/

using Generator;

namespace _2._8_List_perfect_squares
{
    internal class Program
    {
        static void on_all(List<int> list, Action<int> func) => list.ForEach(x => func(x));

        static bool IsPerfectSquare(int i)
        {
            return Math.Abs(Math.Sqrt(i) % 1) <= (Double.Epsilon * 100);
        }

        static string PrintList(List<int> list) => String.Join(", ", list);

        static void Main(string[] args)
        {
            List<int> list = ListGen.GetList(100);
            Console.WriteLine("Elements: " + PrintList(list));

            Console.Write("Perfect squares: ");
            int count = 0;
            on_all(list, (x) =>
            {
                if (count < 20 && IsPerfectSquare(x))
                {
                    if (count > 0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(x);
                    count++;
                }
            });
        }
    }
}
