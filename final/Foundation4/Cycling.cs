public class Cycling : Activity
{
    private double _cyclingSpeed;
    private double _cyclingPace;
    private double _cyclingDistance;

    public Cycling(string date, double minutes, double speed) : base(date, minutes)
    {
        _cyclingSpeed = speed;
    }
    
    override public void Calculate()
    {
        _cyclingPace = 60 / _cyclingSpeed;
        _cyclingDistance = _cyclingSpeed * _minutes;
    }


    public override void GetSummery()
    {
        Console.WriteLine($"{_date} Running ({_minutes:N2}) min - Distance {_cyclingDistance:N2} miles, Speed {_cyclingSpeed:N2} mph, Pace: {_cyclingPace:N2} min per mile");
    }
}