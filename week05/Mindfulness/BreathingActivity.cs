using System;

//This class inherits from "Activity" base class by using the ":" symbol
public class BreathingActivity : Activity
{
    //Constructor: It passes values directly to parent constructor using "base()"
    public BreathingActivity() :
        base("Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    //Main method to run the breathing routine
    public void Run()
    {
        //Call welcome message and get session duration from base class
        StartMessage();
        //How long the activity should run based on user input
        int duration = GetDuration();
        //Create timestamp for when the sessions should stop
        DateTime end = DateTime.Now.AddSeconds(duration);

        //Loop keeps repeating breathing cycle until clock hits "end" time
        while (DateTime.Now < end)
        {
            //Tell user to inhale and start a visual countdown of 4s
            Console.Write("\nBreathe in... ");
            Countdown(4);
            //Tell user to exhale and start a visual countdown of 6s
            Console.Write("\nBreathe out... ");
            Countdown(6);

            Console.WriteLine();//Add blank line space between breathing cycles
        }
        //Calls closing message from base class to finish activity
        EndMessage();
    }
}