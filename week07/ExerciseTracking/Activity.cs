using System;
using System.Collections.Generic;

// Base Class
public abstract class Activity
{
    private DateTime _date;
    private int _lengthMinutes;

    protected Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public DateTime Date => _date;
    public int LengthMinutes => _lengthMinutes;

    // Abstract methods (polymorphism)
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method using abstract methods
    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({LengthMinutes} min)- " +
               $"Distance: {GetDistance():0.0} km, " +
               $"Speed: {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.0} min/km";
    }

    public virtual string GetDetailedDisplay()
    {
        return $"{GetType().Name} on {Date:dd MMM yyyy}:\n" +
               $"  Minutes: {LengthMinutes}\n" +
               $"  Distance: {GetDistance():0.00} km\n" +
               $"  Speed: {GetSpeed():0.00} kph\n" +
               $"  Pace: {GetPace():0.00} min/km";
    }
}