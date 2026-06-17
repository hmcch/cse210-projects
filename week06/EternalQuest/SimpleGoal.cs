public class SimpleGoal : Goal//This class inherits from "Goal" by using ":" keyword
{
    private bool _isComplete;//Private boolean variable to keep track if the simple gal has been accomplished or not

    //Constructor - This executes whenever a new SimpleGoal object using "new" is created.
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)//"base" passes name, description and points to the parent Goal constructor
    {
        _isComplete = false;
    }

    public override void RecordEvent()//Override to change how the parent abstract RecordEvent method works for this specific class
    {
        Console.WriteLine($"Event recorded for '{_shortName}' (+{_points} points)");//Prints message to console using string interpolation ($)
        _isComplete = true;//// Because this is a simple goal (like "finishing essay"), doing it once flags its done
    }

    public override bool IsComplete()//// Override parent IsComplete method to return a bool value.
    {
        return _isComplete;
    }

    public override string GetDetailsString()//Override to change how the goal is displayed on screen when listed as the menu
    {
        string box = _isComplete ? "[X]" : "[ ]";//If IsComplete() is true, box becomes "[X]". If false, box becomes "[ ]"
        return $"{box} {_shortName} ({_description})";// Returns readable sentence showing the checkbox, name and description
    }

    public override string GetStringRepresentation()//Override to format data for text-file savings
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";//Use vertical bars "|" as separator for reading the text file more easily
    }
}