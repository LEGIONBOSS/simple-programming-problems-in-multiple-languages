/*
Write a program that asks the user for their name and greets them with their
name.
*/

namespace _1._2_Greeting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }
    }
}
