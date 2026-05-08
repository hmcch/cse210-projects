using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {   // Ask for user input on their percentage

        Console.Write("Type your grade in percentage using only integer numbers: ");
        string percent = Console.ReadLine();
        int percentConverted = int.Parse(percent);

        string letter = "";

        // Determine the letter grade based on the percentage

        if (percentConverted >= 90)
        {
            letter = "A";
        }
        else if (percentConverted >= 80 && percentConverted <= 89)
        {
            letter = "B";
        }
        else if (percentConverted >= 70 && percentConverted <= 79)
        {
            letter = "C";
        }
        else if (percentConverted >= 60 && percentConverted <= 69)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        int lastDigit = percentConverted % 10;

        if (lastDigit >= 7 && percentConverted >= 97 || percentConverted >= 97)// Handle the +A grades
        {
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }
        else if (percentConverted <= 59 || letter == "F")// Handle the F- and F+ grades
        {
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }
        else if (lastDigit >= 7)
        {
            Console.WriteLine($"Your grade is: {letter}+");
        }
        else if (lastDigit < 3)
        {
            Console.WriteLine($"Your grade is: {letter}-");
        }
        else
        {
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }


        // Display student grade with a message. Note-passing the course requires a 70%

        if (percentConverted >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You failed the course. Keep improving and you will do it better for the next time.");
        }
    }
}