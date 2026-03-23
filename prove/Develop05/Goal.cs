class Goal
{
    protected string _description;
    protected string _name;
    protected int _pointValue;


    public Goal() { }

    virtual public void InputGoal()
    {
        Console.Write("What is the name of your goal: ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of your goal: ");
        _description = Console.ReadLine();
        Console.Write("Write the amount of points you think your goal is worth: ");
        string pointValue = Console.ReadLine();
        _pointValue = int.Parse(pointValue);
    }

    virtual public string GetGoal()
    {    
        return $"SimpleGoal|{_name}|{_description}|{_pointValue}";
    }
    virtual public string DisplayGoal()
    {
        return $"{_name} ({_description}).";
    }

    virtual public bool Check()
    {
        //true means it's ok to delet goal
        return true;
    }

    virtual public int GetPointVal()
    {
        return _pointValue;
    }

    virtual public void RecordProgress()
    {
        
    }
}

