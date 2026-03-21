using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List as many things as you are grateful for today.",
        "List moments from this week that made you smile.",
        "List things in your life that bring you comfort.",
        "List personal strengths you’ve shown recently.",
        "List things you’ve done that required courage.",
        "List accomplishments you’re proud of, big or small.",
        "List ways you’ve helped others recently.",
        "List things you appreciate about someone close to you.",
        "List goals you want to work toward this month.",
        "List habits you want to build or strengthen.",
        "List things that inspire your creativity.",
        "List characters, stories, or worlds you’d like to create.",
        "List objects you could repurpose into something new."
    };

    public ListingActivity(string name, string description) : base(name, description)
    {
    }

    private string GetPrompt()
    {
        Random prompt = new Random();
        int i = prompt.Next(_prompts.Count);
        return _prompts[i];
    }

    public void InitiateListingActivity()
    {
        StartingMessage();
        GetDuration();

        Console.WriteLine("Ponder on the prompt:");

        string _showPrompt = GetPrompt();
        Console.WriteLine($"\n{_showPrompt}\n");

        ShowTime(8);

        List<string> numItems = new();
        DateTime endTime = DateTime.Now.AddSeconds(_durationSeconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("~ ");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(userInput))
            {
                numItems.Add(userInput);
            }

        }

        Console.WriteLine($"\nYou made {numItems.Count()} entries.\n");

        EndingMessage();
    }
}