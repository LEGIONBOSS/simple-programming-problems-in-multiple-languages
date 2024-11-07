/*
Write three functions that compute the sum of the numbers in a list: using a for-loop, a while-loop and recursion. (Subject to availability of these constructs in your language of choice.)
*/

using Generator;

namespace _2._7_List_sums
{
    internal class Program
    {
        static int Sum_For(List<int> list)
        {
            int sum = list.ElementAt(0);
            for (int i = 1; i < list.Count; i++)
            {
                sum += list.ElementAt(i);
            }
            return sum;
        }

        static int Sum_While(List<int> list)
        {
            int sum = list.ElementAt(0),
                i = 1;
            while (i < list.Count)
            {
                sum += list.ElementAt(i);
                i++;
            }
            return sum;
        }

        static int Sum_Recursion(List<int> list, int index = 0)
        {
            if (index < list.Count)
            {
                return list.ElementAt(index) + Sum_Recursion(list, index + 1);
            }
            else
            {
                return 0;
            }
        }

        static string PrintList(List<int> list) => String.Join(", ", list);

        static void Main(string[] args)
        {
            List<int> list = ListGen.GetList(100);
            Console.WriteLine("Elements: " + PrintList(list));

            Console.WriteLine("For loop:\t" + Sum_For(list));
            Console.WriteLine("While loop:\t" + Sum_While(list));
            Console.WriteLine("Recursion:\t" + Sum_Recursion(list));
        }
    }
}
