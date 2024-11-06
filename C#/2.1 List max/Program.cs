/*
Write a function that returns the largest element in a list.
*/

using Generator;

namespace _2._1_List_max
{
    internal class Program
    {
        private static int GetLargest(List<int> list) => list.Max();

        static void Main(string[] args)
        {
            List<int> list = ListGen.GetList(100);

            // List elements
            Console.Write("Elements: ");
            list.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();

            // Print largest element
            Console.WriteLine("Largest element: " + GetLargest(list));
        }
    }
}
