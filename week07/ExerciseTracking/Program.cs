using System;
using System.Collections.Generic;
// Main program
class Program
{
    static void Main()
    {
        //Polymorphism. Using the "Activity" base class it lets
        //to store and access other derived types (Running, Cycling, Swimming)
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 5.0),
            new Cycling(new DateTime(2022, 11, 3), 45, 15.0),
            new Swimming(new DateTime(2022, 11, 3), 60, 24)
        };

        //Summaries
        Console.WriteLine("Exercise Summary");
        Console.WriteLine("-------------------------");
        Console.WriteLine();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine();

        //Exercise in Details
        Console.WriteLine("Exercise in Details:");
        Console.WriteLine("----------------------");
        Console.WriteLine();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetDetailedDisplay());
            Console.WriteLine();
        }
    }
}