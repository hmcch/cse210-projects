using System;
using System.Collections.Generic;//To be able to use Lists to store user answers

//Inherits from "Activity" class
public class ListingActivity : Activity
{
    //List of prompts topics for the user to get assigned
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are your personal heroes?"
    };

    //Constructor - Assign name and details for activity
    public ListingActivity() :
        base("Listing Activity",
        "This activity helps you list the positive things in your life.")
    { }

    //Method to handle logic of asking a topic and storing user answers
    public void Run()
    {   //To trigger parent start process - clear console and ask for a timer
        StartMessage();

        Random rnd = new Random();
        Console.WriteLine("\nList as many responses as you can for the following prompt:");
        //Select a random prompt of the available list
        Console.WriteLine($"--- {_prompts[rnd.Next(_prompts.Count)]} ---");

        //Give user 5 s countdown to prepare their thoughts
        Console.Write("\nYou may begin in: ");
        Countdown(5);////Run base class countdown timer widget

        //Create an empty list to store items typed by user during program execution
        List<string> items = new List<string>();
        int duration = GetDuration();//Grab timer data input from parent class
        DateTime end = DateTime.Now.AddSeconds(duration);//Mark closing boundary time

        //Requesting and tracking text strings until current clock matches "end" mark
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            //Capture every input the user typed and store it inside the list
            items.Add(Console.ReadLine());
        }
        //Display total count of answers stored by the user typing
        Console.WriteLine($"\nYou listed {items.Count} items!");
        //Trigger closing sequence animation from base class
        EndMessage();
    }
}