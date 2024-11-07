/*
Write a function that combines two lists by alternatingly taking elements, e.g. [a,b,c], [1,2,3] → [a,1,b,2,c,3].
*/

using Generator;

namespace _2._10_List_interwine
{
    internal class Program
    {
        static List<int> Interwine(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < Math.Max(list1.Count, list2.Count); i++)
            {
                // Remainder goes at the end
                if (i < list1.Count)
                {
                    result.Add(list1.ElementAt(i));
                }
                if (i < list2.Count)
                {
                    result.Add(list2.ElementAt(i));
                }
            }
            return result;
        }

        static string PrintList(List<int> list) => String.Join(", ", list);

        static void Main(string[] args)
        {
            List<int> list1 = ListGen.GetList(5),
                list2 = ListGen.GetList(8);
            Console.WriteLine("Elements(1): " + PrintList(list1));
            Console.WriteLine("Elements(2): " + PrintList(list2));

            List<int> listInterwine = Interwine(list1, list2);
            Console.WriteLine("Elements(1+2): " + PrintList(listInterwine));
        }
    }
}
