/*
Modify the previous program such that only the users Alice and Bob are greeted with their names.
*/

namespace _1._3_Selective_greeting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hello");
            if (name == "Alice" ||  name == "Bob")
            {
                Console.Write(" " + name);
            }
            Console.WriteLine("!");
        }
    }
}
