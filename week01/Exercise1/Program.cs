using System;
// All core requirements accomplished.
class Program
{
    static void Main(string[] args)
    {

        // Ask the user for their first name.
        Console.Write("What is you first name? ");
        string firstName = Console.ReadLine();

        // Ask the user for their last name.
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Concatenate and display last name, first name, last name.
        Console.WriteLine();
        Console.Write($"Your name is {lastName}, {firstName} {lastName}.");

    }
}