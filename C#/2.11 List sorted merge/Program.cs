/*
Write a function that merges two sorted lists into a new sorted list. [1,4,6], [2,3,5] → [1,2,3,4,5,6]. You can do this quicker than concatenating them followed by a sort.
*/

namespace _2._11_List_sorted_merge
{
    internal class Program
    {
        private static List<int> ConcantSortLists(List<int> list1, List<int> list2)
        {
            return list1.Concat(list2).Order().ToList();
        }

        static string PrintList(List<int> list) => String.Join(", ", list);

        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 4, 6 },
                list2 = new List<int> { 2, 3, 5 };
            Console.WriteLine("Elements(1): " + PrintList(list1));
            Console.WriteLine("Elements(2): " + PrintList(list2));

            Console.WriteLine("Elements (concatted & sorted): " + PrintList(ConcantSortLists(list1, list2)));
        }
    }
}
