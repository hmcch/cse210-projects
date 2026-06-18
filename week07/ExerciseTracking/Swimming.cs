// Derived Class: Swimming
//"Swimming" inherits from "Activity" to have access to all its shared properties, methods and constructor
public class Swimming : Activity
{
    private int _laps;

    //Constructor - Using the ":" base keyword it passes
    //the date and duration to the "Activity" parent class
    public Swimming(DateTime date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;//To initialize the specific property exclusively to Swimming
    }

    //50 meters per lap converted to kilometers (laps * 50 / 1000)
    public override double GetDistance() => _laps * 0.05;
    //Calculate hourly swimming speed
    public override double GetSpeed() => (GetDistance() / LengthMinutes) * 60;
    //Calculate minutes required per kilometer
    public override double GetPace() => LengthMinutes / GetDistance();
}