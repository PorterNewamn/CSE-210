public class Listing : Activity
{
    private string _prompt;
    private int _count;
    private string _promt;

    Random random = new Random();

    List<string> randomPrompt = new List<string>
    {
        " --- When have you felt the Holy Ghost? --- ",
        " --- How did you feel when you recived your endowment? --- ",
        " --- What where some of the key moments on your most favorit adventure? --- ",
        " --- What are some of the places you want to visit? --- ",
        " --- If you could mast any skills what skills would you want to master? --- ",
        " --- Who are some of your closes friends --- ",
        " --- What are some things you are greatful for? --- "
    };
    public Listing()
    {
        
    }

    public void RunListing()
    {
        SetRandomPrompt();
        Console.Clear();
        Console.Write(SetStart(3));
        string input = Console.ReadLine();
        _timer = int.Parse(input);
        Console.Clear();
        GetReady();
        Console.Clear();
        Console.WriteLine("List as many responses to the following prompt:");
        Console.WriteLine("\n" + _prompt + "\n");
        // I included the same line from the reflection class so that the person could think of some responses.
        Console.WriteLine("When you have something in minde, press enter to begin.");
        Console.ReadLine();
        Console.Write("You may begin in...");
        VisTimer(3);
        Console.WriteLine("");
        DateTime endTime = GetEndTime();
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            _count += 1;
        }
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine("");
        RLineOne();
        Animation(3);
        RLineTwo(_timer, 3);
        Animation(5);
    }

    public string SetRandomPrompt()
    {
        int randomIndex = random.Next(randomPrompt.Count());
        _prompt = randomPrompt[randomIndex];
        return _prompt;
    }
}