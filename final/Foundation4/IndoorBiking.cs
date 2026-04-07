public class IndoorBiking : Activity
{
    public IndoorBiking(int duration, string date, decimal distance, decimal speed, decimal pace) : base(duration, date, distance, speed, pace)
    {
    }

    public override decimal CalculateDistance()
    {
       return GetSpeed() * (GetDuration() / 60m);
    }

    public override decimal CalculateSpeed()
    {
        return GetDistance() / GetDuration() / 60m;
    }

    public override decimal CalculatePace()
    {
        return GetDuration() / GetDistance();
    }

    public override void GetSummary()
    {
        Console.WriteLine($"\n{GetDate()} Stationary Biking ({GetDuration()} min): Distance {CalculateDistance().ToString("F1")} km, Speed {GetSpeed().ToString("F1")} kph, Pace {CalculatePace().ToString("F1")} min per km\n");
    }
}