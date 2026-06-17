//This class inherits from parent class "Goal" by key ":"
public class ChecklistGoal : Goal
{
    //Private variables only this specific class can see
    private int _amountCompleted;//how many times the user has actually done this task up to this point
    private int _target;//total number of times required to accomplish the goal
    private int _bonus;//Extra points earned only when the target amount is hit

    //Constructor - Run automatically when a new CheckList object is created
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)//"base" passes name, description and points to the parent Goal constructor
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;//Every new checklist goal begins at zero
    }

    public override void RecordEvent()//Override to change how the parent abstract RecordEvent method works for this specific class
    {
        _amountCompleted++;
        Console.WriteLine($"Progress recorded for '{_shortName}' (+{_points} points)");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Checklist complete! Bonus +{_bonus} points!");
        }
    }

    public override bool IsComplete()//Override the parent IsComplete method to return a bool value
    {
        return _amountCompleted >= _target;
    }

    public int GetBonus()//Simple getter method so other classes can read "_bonus" value
    {
        return _bonus;
    }

    public override string GetDetailsString()//Override to change how this goal displays on screen when listed in the menu.
    {
        //If IsComplete() is true, box becomes "[X]". If false, box becomes "[ ]"
        string box = IsComplete() ? "[X]" : "[ ]";
        // Returns readable sentence showing the checkbox, name, description and progress fraction.
        return $"{box} {_shortName} ({_description}) — Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()//Override to format data for text-file savings
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";//Use vertical bars "|" as separator for reading the text file more easily
    }
}