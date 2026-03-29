
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete = false;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    protected string MarkCopmpleted()
    {
        if (_isComplete)
        {
            return "X";
        }
        else
        {
            return "";
        }
    }

    protected bool CompleteGoal()
    {
        return _isComplete = true;
    }

    public void SetIsComplete(bool complete)
    {
        _isComplete = complete;
    }
    

    public abstract void GetDetails();
    public abstract string GetStringRepresentation();
    public abstract string GoalString();
    public abstract int RecordEvent();
}