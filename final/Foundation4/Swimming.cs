public class Swimming : Activity
{
    private int _laps;
    public Swimming(int duration, string date, decimal distance, decimal speed, decimal pace) : base(duration, date, distance, speed, pace)
    {
    }

    public Swimming(int duration, string date, decimal distance, decimal speed, decimal pace, int laps) : base(duration, date, distance, speed, pace)
    {
        _laps = laps;
    }

    public override decimal CalculateDistance()
    {
       return (_laps * 50) / 1000;
    }

    public override decimal CalculateSpeed()
    {
        return (GetDistance() / 1000) / GetDuration();
    }

    public override decimal CalculatePace()
    {
        return GetDistance() / (50 * GetDuration());
    }

    public override void GetSummary()
    {
        Console.WriteLine($"\n{GetDate()} Swimming ({GetDuration()} min): Number of laps: {_laps}, Distance {CalculateDistance().ToString("F1")} km, Speed {CalculateSpeed().ToString("F1")} kph, Pace {CalculatePace().ToString("F1")} min per km\n");
    }
}