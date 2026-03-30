public class Event
{
    private string _eventName;
    private string _description;
    private string _date;
    private string _time;

    
    public Event(){}

    public void SetEvent(string name, string descrip, string date, string time)
    {
        _eventName = name;
        _description = descrip;
        _date = date;
        _time = time;
    }

    
    public void Standard()
    {
       Console.WriteLine($"{_eventName}\n{_description}\n {_date} - {_time}");
    }

    public void Title()
    {
        Console.WriteLine(_eventName);
    }
    public void Description()
    {
        Console.WriteLine(_description);
    }
    public void Date()
    {
         Console.WriteLine(_date);
    }
    public void Time()
    {
        Console.WriteLine(_time);
    }

    public void DisplayAddress(int index)
    {
        Address a = new Address();
        Console.WriteLine(a.GetAddress(index));
    }
    
}