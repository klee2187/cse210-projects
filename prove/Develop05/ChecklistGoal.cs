
public class ChecklistGoal : Goal
{
    private int _target;
    private int _numCompleted = 0;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    private int NumToTarget()
    {
        return _numCompleted++;
    }

    public void SetNumCompleted(int completed)
    {
        _numCompleted = completed;
    }

    public override void GetDetails()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("Give a short description of your goal: ");
        _description = Console.ReadLine();

        Console.Write("How many points will you earn for it? ");
        _points = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _target = int.Parse(Console.ReadLine());

        Console.Write("What would you like the bonus for finishing this goal to be? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override string GetStringRepresentation()
    {
		return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_numCompleted},{_target}";
		
    }

    public override string GoalString()
    {
        return $"[{MarkCopmpleted()}] | {GetName()} | {GetDescription()} | {GetPoints()} | {_bonus} Completed: {_numCompleted}/{_target} | {_isComplete}";
        
    }

    public override int RecordEvent()
    {
        NumToTarget();
        if (_numCompleted == _target)
        {
            CompleteGoal();
            int points = _bonus + GetPoints();
            return points;
        }
        else
        {
            return GetPoints();
        }
    }
}