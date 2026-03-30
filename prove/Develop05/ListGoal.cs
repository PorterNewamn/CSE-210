public class ListGoal : Goal
{
    private int _track = 0;
    private int _threshold;
    private int _bounus;

    public ListGoal() : base ()
    {
        
    }

    public override void InputGoal()
    {
        base.InputGoal();
        Console.Write("Enter the amount of times you would like to complete this goal: ");
        string inputValue = Console.ReadLine();
        _threshold = int.Parse(inputValue);
        Console.Write($"Enter the amount of Bonus points this goal is worth after you have commpleted your goal {_threshold} times: ");
        string userBonus = Console.ReadLine();
        _bounus = int.Parse(userBonus);

    }

    override public void RecordProgress()
    {
        _track += 1;
    }

    override public bool Check()
    {
        return _track >= _threshold;
    }

    public override string DisplayGoal()
    {
        return $"{_name} ({_description}) -- Curently completed: {_track}/{_threshold}";
    }

    public override string GetGoal()
    {
        return $"ListGoal|{_name}|{_description}|{_pointValue}|{_bounus}|{_threshold}|{_track}";
    }

    public void SetTrack()
    {
        _track += 1;
    }

    public override int GetPointVal()
    {
        if (_track == _threshold)
        {
            return _bounus + _pointValue;
        }
        else
        {
            return _pointValue;
        }
    }
}