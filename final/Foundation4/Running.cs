
public class Running : Activity
{
    public Running(int duration, string date, decimal distance, decimal speed, decimal pace) : base(duration, date, distance, speed, pace)
    {
    }

    public override decimal CalculateDistance()
    {
       return GetDuration() / GetPace();
    }

    public override decimal CalculateSpeed()
    {
        return GetDistance() / GetDuration();
    }

    public override decimal CalculatePace()
    {
        return GetDuration() / GetDistance();
    }

    public override void GetSummary()
    {
        Console.WriteLine($"\n{GetDate()} Running ({GetDuration()} min): Distance {GetDistance()} km, Speed {CalculateSpeed().ToString("F1")} kph, Pace {CalculatePace().ToString("F1")} min per km\n");
    }
}