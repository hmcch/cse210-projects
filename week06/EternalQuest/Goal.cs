using System;

//It is not possible to create a Goal object directly
//The only option is to make object out of its child classes, ie SimpleGoal or EternalGoal
public abstract class Goal
{
    //"protected" to keep variables private from outside 
    // but allow child classes to access and use them
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)// Constructor: This initializes the base data whenever a child class calls it using ': base'
    {
        //Saving passed arguments into protected variables
        _shortName = name;
        _description = description;
        _points = points;
    }

    //Getter method. Because "_points" is protected/private, 
    //other classes like GoalManager can access it directly.
    public int GetPoints()
    {
        return _points;
    }

    //By using abstract methods it lets force every single child class
    //to create is own custom version of these method by using "override" keyword
    public abstract void RecordEvent();//To force child classes to define what happens when the user finishes or makes progress on this goal 
    public abstract bool IsComplete();//To force child classes to return bool value checking if the goal is finished.
    public abstract string GetDetailsString();//To force child classes return a custom text string showing how it should look like a list.
    public abstract string GetStringRepresentation();//To force child classes to format its data into a custom text line for saving to a file.
}