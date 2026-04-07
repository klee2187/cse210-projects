public abstract class Activity
{
    private int _duration;
    private string _date;
    private decimal _distance;
    private decimal _speed;
    private decimal _pace;

    public Activity(int duration, string date, decimal distance, decimal speed, decimal pace)
    {
        _duration = duration;
        _date = date;
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetDate()
    {
        return _date;
    }

    public decimal GetDistance()
    {
        return _distance;
    }

    public decimal GetSpeed()
    {
        return _speed;
    }

    public decimal GetPace()
    {
        return _pace;
    }

    public abstract decimal CalculateDistance();
    public abstract decimal CalculateSpeed();
    public abstract decimal CalculatePace();
    public abstract void GetSummary();
}