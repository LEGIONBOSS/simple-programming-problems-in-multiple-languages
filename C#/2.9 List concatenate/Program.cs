/*
Write a function that concatenates two lists. [a,b,c], [1,2,3] → [a,b,c,1,2,3]
*/

using Generator;

namespace _2._9_List_concatenate
{
    internal class Program
    {
        static List<int> ConcatLists(List<int> list1, List<int> list2)
        {
            return list1.Concat(list2).ToList();
        }

        static string PrintList(List<int> list) => String.Join(", ", list);

        static void Main(string[] args)
        {
            List<int> list1 = ListGen.GetList(10),
                list2 = ListGen.GetList(10);
            Console.WriteLine("Elements(1): " + PrintList(list1));
            Console.WriteLine("Elements(2): " + PrintList(list2));

            List<int> listConcat = ConcatLists(list1, list2);
            Console.WriteLine("Elements(1+2): " + PrintList(listConcat));
        }
    }
}
