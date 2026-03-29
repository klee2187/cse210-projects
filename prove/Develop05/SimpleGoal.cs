public class SimpleGoal : Goal
{   
    List<Goal> goals = new List<Goal>();
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
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
		return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()}";
		
    }

    public override string GoalString()
    {
       return  $"[{MarkCopmpleted()}] | {GetName()} | {GetDescription()} | {GetPoints()} {_isComplete}";
    
    }

    public override int RecordEvent()
    {
        CompleteGoal();
        return GetPoints();
    }
   
    
}