using System;

//  Derived Class: Cycling
//"Cycling" inherits from "Activity" (Cycling is an Activity)
public class Cycling : Activity
{
    private double _speedKph;

    //Constructor - The ":" base keyword is used to set shared "_date" and "_lengthMinutes"
    public Cycling(DateTime date, int lengthMinutes, double speedKph)
        : base(date, lengthMinutes)
    {
        _speedKph = speedKph; //To initialize the specific property exclusively to Cycling
    }

    //Calculate distance
    public override double GetDistance() => (_speedKph * LengthMinutes) / 60;
    //Return the stored speed now that the values are already in kph
    public override double GetSpeed() => _speedKph;
    //Use the hint (Pace = 60 / Speed) to find minutes per kilometer
    public override double GetPace() => 60 / _speedKph;
}