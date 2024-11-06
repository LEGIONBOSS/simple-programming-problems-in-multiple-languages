/*
Write a function that returns the elements on odd positions in a list.
*/

using Generator;

namespace _2._4_List_odd_positions
{
    internal class Program
    {
        private static List<int> OddPosElements(List<int> list)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i += 2) // First position is index 0
            {
                result.Add(list.ElementAt(i));
            }
            return result;
        }

        private static string PrintList(List<int> list) => String.Join(", ", list);

        static void Main(string[] args)
        {
            List<int> list = ListGen.GetList(100);

            // List elements
            Console.WriteLine("Elements: " + PrintList(list));

            // List odd indexed elements
            Console.WriteLine("Odd indexed elements: " + PrintList(OddPosElements(list)));
        }
    }
}
