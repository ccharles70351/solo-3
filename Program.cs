using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int random_number = new Random().Next(1, 10);
            // Console.WriteLine(random_number);
            Console.WriteLine("Guess the random number!");
            string input = Console.ReadLine();
            int guess = int.Parse(input); 
            while (guess != random_number)
            {
                Console.Write("Try again!");
                guess = int.Parse(Console.ReadLine());
                // int guess = int.Parse(input); 
            }
            Console.WriteLine($"You guessed the number! It was {random_number}");

        }
    }
}