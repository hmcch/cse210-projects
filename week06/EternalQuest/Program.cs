using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();//Create a new object instance of the GoalManager class using "new"
        gm.Start();//By using dot operator "." to call the "Start" method on the new manager object.
        // This hands control over to GoalManager, which opens up the main menu loop for the user
    }
}