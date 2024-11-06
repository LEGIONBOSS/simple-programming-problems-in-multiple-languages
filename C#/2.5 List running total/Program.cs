/*
Write a function that computes the running total of a list.
*/

using Generator;

namespace _2._5_List_running_total
{
    internal class Program
    {
        private static int RunningTotal(List<int> list, uint lastIndex)
        {
            if (lastIndex >= list.Count) lastIndex = (uint)list.Count() - 1;

            int result = list.ElementAt(0);
            for (int i = 1; i <= lastIndex; i++)
            {
                result += list.ElementAt(i);
            }
            return result;
        }

        private static string PrintList(List<int> list) => String.Join(", ", list);

        static void Main(string[] args)
        {
            List<int> list = ListGen.GetList(100);

            // List elements
            Console.WriteLine("Elements: " + PrintList(list));

            // Running total
            uint lastIndex = 2;
            Console.WriteLine($"Running total ({lastIndex}): " + RunningTotal(list, lastIndex));
        }
    }
}
