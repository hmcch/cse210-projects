using System;
using System.Collections.Generic;//To be able to use Lists to store text strings

//Inherits from "Activity" class using ":" symbol
public class ReflectingActivity : Activity
{
    //Private list of situational prompts to give user options to think about
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    //Private list of follow-up questions to help user ponder
    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?",
        "How can this help you in the future?"
    };

    //Constructor - Sets this activity name and brief description of it.
    //It passes up to the parent class constructor using "base()" keyword
    public ReflectingActivity() :
        base("Reflection Activity",
        "This activity helps you reflect on times you were strong and resilient.")
    { }
    //Core method to execute reflection routine step by step
    public void Run()
    {
        //Trigger greeting message and ask user for session duration in seconds
        StartMessage();

        //Create random generator object to select random items from lists
        Random rnd = new Random();
        Console.WriteLine("\nConsider the following prompt:");
        //Select and print random string from _prompts list using its count index
        Console.WriteLine($"--- {_prompts[rnd.Next(_prompts.Count)]} ---");
        //Pause execution and wait for user to press Enter before continue
        Console.WriteLine("\nWhen you are ready, press Enter.");
        Console.ReadLine();

        Console.WriteLine("Now reflect on these questions:");
        int duration = GetDuration();//Grab total running seconds specified by user
        DateTime end = DateTime.Now.AddSeconds(duration);//Calculate timestamp to stop loop

        //Loop keeps feeding reflection question until session time is over
        while (DateTime.Now < end)
        {
            //Select a random question from _questions list
            string q = _questions[rnd.Next(_questions.Count)];
            Console.Write($"> {q} ");
            //Pauses console for 5s with a spinning wheel animation to let user think
            ShowSpinner(5);
            //Blank line spacing before next question
            Console.WriteLine();
        }
        //Closing animation and final message from base class
        EndMessage();
    }
}