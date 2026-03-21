using System.Reflection.Metadata;

public class StretchingActivity : Activity
{
    private List<string> _standingStretches = new List<string>
    {
        "In a standing position, reach up high to the sky as far as you can and hold it",
        "In a standing position, bend forward and try to touch your toes",
        "In a standing position, roll your shoulders slowly backward in a big circle.",
        "In a standing position, gently stretch your arms out wide to the sides and hold.",
        "In a standing position, clasp your hands behind your back and lift your chest slightly.",
        "In a standing position, slowly look up toward the ceiling and hold the stretch.",
        "In a standing position, lower your chin toward your chest and relax your shoulders.",
        "In a standing position, place your hands on your lower back and gently arch forward.",
        "In a standing position, reach both arms forward and round your upper back.",
        "In a standing position, extend your arms forward and gently pull back on your fingertips.",
        "In a standing position, shake out your hands and let your arms relax at your sides.",
        "In a standing position, interlace your fingers and push your palms outward.",
        "In a standing position, lift one knee slightly and hold for a gentle balance stretch.",
        "In a standing position, step one foot back and stretch your calf lightly.",
        "In a standing position, bend one knee and gently pull your heel toward your glutes.",
        "In a standing position, shift your weight side to side to loosen your hips."
    };

    private List<string> _sittingStretches = new List<string>
    {
        "While sitting tall, roll your shoulders slowly forward in a smooth circle.",
        "While sitting, lift both arms overhead and stretch gently toward the ceiling.",
        "While sitting, clasp your hands behind your head and gently open your elbows wide.",
        "While sitting, lower your chin toward your chest and relax your neck.",
        "While sitting, gently look up toward the ceiling and soften your jaw.",
        "While sitting, reach both arms forward and round your upper back.",
        "While sitting, place your hands on your knees and gently arch your back.",
        "While sitting, interlace your fingers and push your palms outward.",
        "While sitting, stretch both arms out to the sides and open your chest.",
        "While sitting, shake out your hands and let your arms relax at your sides.",
        "While sitting, extend one leg forward and flex your foot gently.",
        "While sitting, lift one knee toward your chest and hold it lightly.",
        "While sitting, place one ankle over the opposite knee and lean forward slightly.",
        "While sitting, tap your toes lightly and roll your ankles in slow circles."
    };

    public StretchingActivity(string name, string description) : base(name, description)

    {
    }

    protected string GetRandomStandingStretch()
    {
        Random stand = new Random();
        int i = stand.Next(_standingStretches.Count);
        return _standingStretches[i];
    }

    protected string GetRandomSittingStretch()
    {
        Random sit = new Random();
        int i = sit.Next(_sittingStretches.Count);
        return _sittingStretches[i];
    }

    public void InitiateStretchingActivity()
    {
        StartingMessage();
        GetDuration();

        Console.WriteLine("Would you like to do 1-standing or 2-sitting stretches? ");
        string choice = Console.ReadLine();
        
        DateTime endTimer = DateTime.Now.AddSeconds(_durationSeconds);
        while (DateTime.Now < endTimer)
        {
            if (choice == "1")
            {
                string standingStretch = GetRandomStandingStretch();
                Console.WriteLine($"{standingStretch}");

                ShowTime(8);

            }

            if (choice == "2")
            {
                string _sittingStretch = GetRandomSittingStretch();
                Console.WriteLine($"{_sittingStretch}");

                ShowTime(8);
            }
        }

        EndingMessage();
    }
}