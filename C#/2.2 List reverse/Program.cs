/*
Write function that reverses a list, preferably in place.
*/

using Generator;

namespace _2._2_List_reverse
{
    internal class Program
    {
        private static void Reverse(List<int> list) => list.Reverse();

        private static string PrintList(List<int> list) => String.Join(", ", list);

        static void Main(string[] args)
        {
            List<int> list = ListGen.GetList(10);

            // List elements
            Console.WriteLine("Elements: " + PrintList(list));

            // Reverse
            Reverse(list);

            // List elements
            Console.WriteLine("Elements: " + PrintList(list));
        }
    }
}
