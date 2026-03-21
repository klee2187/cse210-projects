public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)

    {
    }

    public void InitiateBreathingActivity()
    {
        StartingMessage();
        GetDuration();
        
        DateTime endTime = DateTime.Now.AddSeconds(_durationSeconds);
        while (DateTime.Now < endTime)
        {
            int timeLeft = (int)(endTime - DateTime.Now).TotalSeconds;
            int breatheIn = Math.Min(4, timeLeft);

            if (breatheIn > 0)
            {
                Console.WriteLine("\nBreathe in...");
                ShowTime(breatheIn);
            }
            
            timeLeft = (int)(endTime - DateTime.Now).TotalSeconds;
            int breatheOut = Math.Min(6, timeLeft);

            if (breatheOut > 0)
            {
                Console.WriteLine("\nBreathe out...");
                ShowTime(breatheOut);
            }
        }

        EndingMessage();
    }
}