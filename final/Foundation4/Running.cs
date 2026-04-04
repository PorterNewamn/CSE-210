public class Running : Activity
{
    private double _runningDistance;
    private double _runningSpeed;
    private double _runningPace;

    public Running(string date, double minutes, double distance) : base(date, minutes)
    {
        _runningDistance = distance;

    }
    override public void Calculate()
    {
        _runningSpeed = (_runningDistance / _minutes) * 60;
        _runningPace = _minutes / _runningDistance;

    }

    public override void GetSummery()
    {
        Console.WriteLine($"{_date} Running ({_minutes:N2}) min - Distance {_runningDistance:N2} miles, Speed {_runningSpeed:N2} mph, Pace: {_runningPace:N2} min per mile");
    }
}