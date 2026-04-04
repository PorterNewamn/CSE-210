public class Swimming : Activity
{
    private double _lapsSwam;
    private double _swimmingSpeed;
    private double _swimmingPace;

    public Swimming(string date, double minutes, double swimmingLaps) : base(date, minutes)
    {
        _lapsSwam = swimmingLaps;
    }
    override public void Calculate()
    {
        _swimmingSpeed = (_lapsSwam / _minutes) * 60;
        _swimmingPace = _minutes / _lapsSwam;
    }

    public override void GetSummery()
    {
        Console.WriteLine($"{_date} Swimming ({_minutes:N2}) min - Distance {_lapsSwam:N2} miles, Speed {_swimmingSpeed:N2} laps per minute, Pace: {_swimmingPace:n2} min per lap");
    }



}