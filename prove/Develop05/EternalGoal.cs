public class EternalGoal : Goal
{
    List<Goal> goals = new List<Goal>();
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void GetDetails()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("Give a short description of your goal: ");
        _description = Console.ReadLine();

        Console.Write("How many points will you earn for it? ");
        _points = int.Parse(Console.ReadLine());
    }

    public override string GetStringRepresentation()
    {

		return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
	
    }

    public override string GoalString()
    {
        return $"[ ] | {GetName()} | {GetDescription()} | {GetPoints()}";
        
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }
    
}