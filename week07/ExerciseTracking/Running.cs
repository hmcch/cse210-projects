using System;
// Derived Class: Running
//"Running" inherits from "Activity" (Running is an Activity)
public class Running : Activity
{
    private double _distanceKm;

    //Constructor - The ":" base keyword is used to set shared "_date" and "_lengthMinutes"
    public Running(DateTime date, int lengthMinutes, double distanceKm)
        : base(date, lengthMinutes)
    {
        _distanceKm = distanceKm;//To initialize the specific property exclusively to Running
    }

    //Calculate distance
    public override double GetDistance() => _distanceKm;
    //Calculate speed in kph based on distance and duration
    public override double GetSpeed() => (_distanceKm / LengthMinutes) * 60;
    //Calculate pace by determining the minutes taken per each kilometer
    public override double GetPace() => LengthMinutes / _distanceKm;
}