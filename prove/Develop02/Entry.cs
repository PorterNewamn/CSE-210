using System.Runtime.InteropServices.Marshalling;

public class Entry
{
    public string _randomPrompt;
    public string _userInput;
    public DateTime today = DateTime.Now;

    Random random = new Random();

    List<string> prompts = new List<string>
    {
    "What is something your are greatful for today?",
    "What was the craziest thing you heard or saw today?",
    "If you could change one thing about today, what would it be and why?",
    "What was the funniest thing you heard or saw today and why?", 
    "What was the nicist complament you gave or heard to day?"
    };

    public string PickRandomPrompt()
    {
        int randomIndex = random.Next(prompts.Count());
        _randomPrompt = prompts[randomIndex];
        return _randomPrompt;
    }
    
   
    public void responsDisplay()
    {
        _randomPrompt = PickRandomPrompt();
        Console.WriteLine($"The prompt of the day is: {_randomPrompt}");
        _userInput = Console.ReadLine();
    }
    public void Display()
    {
        Console.WriteLine($"{today.ToShortDateString()} {_randomPrompt} {_userInput}");
    }

}