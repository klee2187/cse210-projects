public class GetPrompt
{
    public List<string> _prompts = new List<string>
    {
        
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I grateful for today?",
        "Did I help anyone today? Who?",
        "What is something kind I did today?",
        "What is something kind that someone did for me today?",
        "What is one thing I did great today?",
        "What is a thought I had today?",
        "What was the worst thing that happened today?",
        "What is a challenge I faced today?",
        "What is something I learned today?",
        "What did I do today that I am proud of?",
        
    };

    public string RandomPromptGenerator()
        {
        Random prompt = new Random();
        int index = prompt.Next(_prompts.Count);
        return _prompts[index];
        }
}