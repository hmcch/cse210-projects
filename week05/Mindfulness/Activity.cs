using System;
using System.Threading;// To have the option of pausing the console for animations

public class Activity
{   //Private member variables
    private string _name;
    private string _description;
    private int _duration;

    //Constructor - generates basic information when a new activity is selected
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    //Display welcome message and ask user for the time duration desired        
    public void StartMessage()
    {
        Console.Clear();//Cleans the screen
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("GOOD LUCK!!");
        Console.WriteLine(_description);

        //Ask user for input and save it
        Console.WriteLine("\n How long, in seconds, would you like this session? ");
        _duration = int.Parse(Console.ReadLine());//Converts string input to integer

        Console.WriteLine("\n Get ready!!!....");
        ShowSpinner(3);//Pause for 3 seconds while a loading animation is displayed before it starts

    }

    //Displays ending message after user finishes an activity
    public void EndMessage()
    {
        Console.WriteLine("\n Well done!!");
        ShowSpinner(3);//Some moments for the user to recognize its achievement

        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}.");

    }

    //Allow child classes to read the private _duration
    protected int GetDuration()
    {
        return _duration;

    }

    //Creates a spinner animation to run
    protected void ShowSpinner(int seconds)
    {
        //Array containing characters that will form the rotating stick animation
        string[] spin = { "|", "/", "-", "\\" };
        //Calculate when the animation should stop
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;//Index pointer for spin array

        //Loop runs until current time catches up the calculated end time
        while (DateTime.Now < end)
        {
            Console.Write(spin[i]);//Prints current loading character
            Thread.Sleep(200);//Pauses so the user can see it properly
            Console.Write("\b \b");//Delete character just printed to overwrite it
            //Cycle index (0-3) and wrap back to 0 using remainder op
            i = (i + 1) % 4;
        }
    }

    //Create a countdown timer
    protected void Countdown(int seconds)

    {
        //Loop backwards from starting seconds down to 1
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);//Print current number
            Thread.Sleep(1000);//Wait 1 second = 1000 ms
            Console.Write("\b \b");//Delete number so the next one replaces it
        }
    }
}