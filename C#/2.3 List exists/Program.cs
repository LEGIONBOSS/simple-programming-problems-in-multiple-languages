/*
Write a function that checks whether an element occurs in a list.
*/

using Generator;

namespace _2._3_List_exists
{
    internal class Program
    {
        private static bool Occurs(List<int> list, int element) => list.Contains(element);

        private static string PrintList(List<int> list) => String.Join(", ", list);

        static void Main(string[] args)
        {
            List<int> list = ListGen.GetList(100);
            int element = 42;

            // List elements
            Console.WriteLine("Elements: " + PrintList(list));
            
            // Print searched element
            Console.WriteLine("Searched element: " + element);

            // Determine
            Console.Write("The list ");
            Console.Write(Occurs(list, element) ? "contains" : "does not contain");
            Console.WriteLine(" the element");
        }
    }
}
