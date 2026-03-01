using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

public class Breath : Activity
{
    private string _in;
    private string _out;

    public Breath()
    {
        
    }
    public void RunBreath()
    {
        Console.Clear();
        SetIn();
        SetOut();
        Console.Write(SetStart(1));
        Console.ReadLine();
        _timer = 300;
        Console.Clear();
        GetReady();
        DateTime endTime = GetEndTime();
        while (DateTime.Now < endTime)
        {
            Console.Write(In());
            VisTimer(10);
            Console.Write("\n" + Out());
            VisTimer(90);
        }
        Console.Clear();
        RLineOne();
        Animation(4);
        Console.Clear();
        RLineTwo(5, 1);
        Animation(4);
    }
    public void SetIn()
    {
        _in = "\n\nBreath...";
    }

    public void SetOut()
    {
        _out = "Hold your Breath...";
    }

    public string In()
    {
        string breath = _in;
        return breath;
    }

    public string Out()
    {
        string exhail = _out;
        return exhail;
    }

}


