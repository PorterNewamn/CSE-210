public class Reflection : Activity
{
    private string _prompt;
    private string _consider;
    Random random = new Random();

    List<string> randomPrompt = new List<string>
    {
        " --- Think of a time when you where most happy. --- ",
        " --- Think of a time when you were most sad --- ",
        " --- Think of a place where you most feel relax. --- ",
        " --- Think of a place that makes you feel anxious --- ",
        " --- Think of your most dificult time --- ",
        " --- Think of your greatest adventure --- "
    };

    List<string> randomConsider = new List<string>
    {
        "> How did it make you feel?",
        "> What were doing?",
        "> What smells where you smelling?",
        "> Why do you think you felt that way?",
        "> What did you learn from that experience?",
        "> How could you benifit from that experience?",
        "> Would you ever go back?"
    };
    public Reflection()
    {
        
    }

    public void RunListing()
    {
        SetRandomConsider();
        SetRandomPrompt();
        Console.Clear();
        Console.Write(SetStart(2));
        string input = Console.ReadLine();
        _timer = int.Parse(input);
        Console.Clear();
        GetReady();
        Console.Clear();
        Console.WriteLine("Consider the following promt.");
        Console.WriteLine("\n" + _prompt + "\n");
        Console.WriteLine("When you have something in minde, press 'enter' to begin.");
        Console.ReadLine();
        Console.Clear();
        Console.Write($"Now ponder on the following questions as they relate to this experience.\nYou may begin in...");
        VisTimer(6);
        Console.Clear();
        DateTime endTime = GetEndTime();
        while (DateTime.Now < endTime)
        {
            Console.Write(_consider);
            Animation(9);
            SetRandomConsider();
            Console.WriteLine("\n");
        }
        Console.Clear();
        RLineOne();
        Animation(3);
        RLineTwo(_timer, 2);
        Animation(3);
    }

    public string SetRandomPrompt()
    {
        int randomIndex = random.Next(randomPrompt.Count());
        _prompt = randomPrompt[randomIndex];
        return _prompt;
    }

    public string SetRandomConsider()
    {
        int randomIndex = random.Next(randomConsider.Count());
        _consider = randomConsider[randomIndex];
        return _consider;
    }
}