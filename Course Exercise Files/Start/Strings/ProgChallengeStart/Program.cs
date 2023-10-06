using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int count = 0;

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            bool guess = false;
            int current_guess;

            while (!guess) {
                string usrGuess = Console.ReadLine();
                Int32.TryParse(usrGuess, out current_guess);
                if (current_guess == -1) {break;}
                if (current_guess == theNumber) {
                    Console.WriteLine($"Yes, the number was {current_guess}");
                    break;
                }
            }
        }
    }
}
