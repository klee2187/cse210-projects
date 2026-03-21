using System.Diagnostics.Contracts;

public class Activity
{
    protected string _name;
    protected string _description;
    protected double _durationSeconds;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome! You have chosen to participate in the {_name} Activity.");
        Timer(5);
        Console.WriteLine($"{_description}");
        Timer(5);
    }

    public void EndingMessage()
    {
        Console.WriteLine("\nWell Done!");
        Timer(3);
        Console.WriteLine($"You have just completed {_durationSeconds} seconds of the {_name} Activity");
        Timer(3);
    }

    public void Timer(int durationSeconds)
    {
        List<string> spinnerSymbols = new List<string>();
        spinnerSymbols.Add("|");
        spinnerSymbols.Add("/");
        spinnerSymbols.Add("-");
        spinnerSymbols.Add("\\");
        spinnerSymbols.Add("|");
        spinnerSymbols.Add("/");
        spinnerSymbols.Add("-");
        spinnerSymbols.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationSeconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerSymbols[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= spinnerSymbols.Count)
                {
                    i = 0;
                }
        
        }

        Console.WriteLine("");
    }

    public void GetDuration()
    {
         Console.WriteLine("Please enter in seconds, how long you want to do this activity: ");
        _durationSeconds = int.Parse(Console.ReadLine());

    }

    public void ShowTime(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
