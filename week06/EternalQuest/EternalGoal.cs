//This class inherits from parent class "Goal" by key ":"
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)// Constructor: This runs automatically everytime a new EternalGoal object is created
        : base(name, description, points)//"base" passes name, description and points to the parent Goal constructor
    { }

    public override void RecordEvent()//Override to change how the parent abstract RecordEvent method works for this specific class
    {
        Console.WriteLine($"Event recorded for '{_shortName}' (+{_points} points)");//Prints message to console using string interpolation ($)
    }

    public override bool IsComplete()//Override the parent IsComplete method to return a bool value
    {
        return false;//Eternal Goals can only be finished until after Final Judgement so in terms of this mortal life it will always return "false".
    }

    public override string GetDetailsString()//Override to change how the goal is displayed on screen when listed as the menu
    {
        return $"[ ] {_shortName} ({_description})";//Because IsComplete is always "false"
    }

    public override string GetStringRepresentation()//Override to format data for text-file savings
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";//Use vertical bars "|" as separator for reading the text file more easily
    }
}