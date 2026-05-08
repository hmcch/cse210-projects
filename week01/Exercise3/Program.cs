using System;

class Program
{
    static void Main(string[] args)
    {
        // C# Programming Exercise 3: Loops

        // Ask the magic number and the user number
        Console.Write("What is the magic number? ");
        string computerNumber = Console.ReadLine();
        int computerNum = int.Parse(computerNumber);

        Console.Write("What is your guess? ");
        string guessNumber = Console.ReadLine();
        int guessNum = int.Parse(guessNumber);
        // Comparing user number against magic/computer number
        if (guessNum < computerNum)
        {
            Console.Write("Higher");
        }
        else if (guessNum > computerNum)
        {
            Console.Write("Lower");
        }
        else
        {
            Console.Write("You guessed it!");
        }
    }
}