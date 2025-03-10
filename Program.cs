﻿namespace GuessingGame;

class Program
{
    static void Main(string[] args)
    {
        bool isCorrectGuess = false;
        Random random = new Random(); // Generates random numbers

        int randomNum = random.Next(1, 11); // Stores the generated random number

        Console.WriteLine("Welcome to the number guessing game!");
        Console.WriteLine("A number between 1 and 10 will be generated");
        Console.WriteLine("If you guess the correct number you win!\n");

        while (!isCorrectGuess)
        {
            Console.Write("Enter your guess.");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess > randomNum)
            {
                Console.WriteLine("Your guess is too high!");
            }
            else if (guess < randomNum)
            {
                Console.WriteLine("Your guess is too low!");
            }
            else
            {
                Console.WriteLine("Correct!");
                isCorrectGuess = true;
            }
        }

        Console.WriteLine("Congratulations, you have won the game!");

        // Makes the program wait for user input before the Console closes
        Console.ReadKey();
    }
}
