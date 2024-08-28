/*
Write a guessing game where the user has to guess a secret number. After every guess the program tells the user whether their number was too large or too small. At the end the number of tries needed should be printed. It counts only as one try if they input the same number multiple times consecutively.
*/

namespace _1._9_Guessing_game
{
    internal class Program
    {
        static int lower = 0,
                   upper = 100;

        static void Main(string[] args)
        {
            Console.WriteLine($"Guess a number between {lower} and {upper}.");
            
            int guess = lower - 1,
                secret = new Random().Next(lower, upper + 1);
            HashSet<int> guesses = new HashSet<int>();
            
            while (guess != secret)
            {
                Console.Write("Guess: ");
                guess = int.Parse(Console.ReadLine());
                guesses.Add(guess);
                
                if (guess < lower || guess > upper)
                {
                    Console.WriteLine($"Between {lower} and {upper} I said!");
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Too small, try again!");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Too large, try again!");
                }
            }

            Console.WriteLine("Correct!");
            Console.WriteLine($"Number of guesses: {guesses.Count}");
        }
    }
}
