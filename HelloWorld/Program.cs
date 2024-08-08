using System;

class NumberGuessingGame
{
    static void Main()
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");

        while (guess != targetNumber)
        {
            Console.Write("Enter your guess: ");
            bool isValid = int.TryParse(Console.ReadLine(), out guess);

            if (!isValid)
            {
                Console.WriteLine("Please enter a valid number.");
                continue; 
            }

            attempts++;

            if (guess < targetNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You've guessed the correct number in {attempts} attempts.");
            }
        }
    }
}
