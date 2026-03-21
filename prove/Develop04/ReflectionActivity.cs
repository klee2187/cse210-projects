public class ReflectionActivity : Activity
{
    
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you surprised yourself with your own strength.",
        "Think of a time when you kept going even though you wanted to quit.",
        "Think of a time when you solved a problem you didn’t think you could.",
        "Think of a time when you stayed calm under pressure.",
        "Think of a time when you made someone’s day better without realizing it at first.",
        "Think of a time when you forgave someone even though it was hard.",
        "Think of a time when you showed compassion to someone who needed it.",
        "Think of a time when someone trusted you and you rose to the moment.",
        "Think of a time when you did something that scared you.",
        "Think of a time when you took a risk that paid off.",
        "Think of a time when you felt deeply proud of yourself.",
        "Think of a time when you made a choice that aligned with your values.",
        "Think of a time when you helped someone understand something difficult.",
        "Think of a time when you turned a mistake into something useful."
    };

    private List<string> _questions = new List<string>
    {
        "How might remembering this experience help you in a difficult moment?",
        "What would repeating this success look like in a new situation?",
        "How did this moment change you or shape who you are today?",
        "What would you tell your past self if you could revisit that moment?",
        "How did this experience make you feel at the time?",
        "How do you feel about it now, looking back?",
        "What motivated you to act the way you did?",
        "What options did you consider before choosing what you did?",
        "How did your values influence your decisions in that moment?",
        "How can you use what you learned from this experience in other areas of your life?",
        "What habits or mindsets from that moment could you carry forward?",
        "What did this experience teach you about yourself?",
        "What emotions surprised you during or after the experience?",
        "What part of the experience brought you the most peace or pride?",
        "What strengths did you rely on to get through it?",
        "How might this experience help you handle future challenges?"
    };

    public ReflectionActivity(string name, string description) : base(name, description)
    {
    }

    protected string GetPrompt()
    {
        Random prompt = new Random();
        int i = prompt.Next(_prompts.Count);
        return _prompts[i];
    }

    protected string GetQuestion()
    {
        Random question = new Random();
        int i = question.Next(_questions.Count);
        return _questions[i];
    }

    public void InitiateReflectionActivity()
    {
        StartingMessage();
        GetDuration();

        Console.WriteLine("\nTake a moment to ponder on this prompt: ");

        String _showPrompt = GetPrompt();
        Console.WriteLine($"\n{_showPrompt}\n");

        Console.WriteLine("Press enter when you are ready to continue...");
        Console.ReadLine();

        Console.WriteLine("Reflect on the following questions as they are given to you:\n");
        
        DateTime endTimer = DateTime.Now.AddSeconds(_durationSeconds);
        while (DateTime.Now < endTimer)
        {
           string _showQuestion = GetQuestion();
           Console.WriteLine($"{_showQuestion}");
           ShowTime(8);
        }

        EndingMessage();
    
    }
}