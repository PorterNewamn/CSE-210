using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

public class Activity
{
    private List<string> _start = new List<string>();
    protected int _timer;
    private List<string> _animationString = new List<string>();
    public Activity()
    {
        _animationString.Add("|");
        _animationString.Add("/");
        _animationString.Add("-");
        _animationString.Add("\\");
    }
    public void Animation(int number)
    {
        for (int i = number; i > 0; i--)
        {
            foreach (string s in _animationString)
            {
                Console.Write(s);
                Thread.Sleep(150);
                Console.Write("\b \b");
            }

        }

        Console.Write(" ");

    }

    public void GetReady()
    {
        Console.WriteLine("Get Ready!!");
        Animation(4);
    }
    public void VisTimer(int number)
    {
        for (int i = number; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i >= 10)
            {
                Console.Write("\b\b  \b\b");
            }
            else
            {
                Console.Write("\b \b");
            }
        }
    }

    public DateTime GetEndTime()
    {
        return DateTime.Now.AddSeconds(_timer);
    }

    public string SetStart(int i)
    {
        _start.Add("Welcom to the BREATHING ACTIVITY! \n\nThis activity will help you become better at holding your breath, and by so doing\nyou will become more relaxed and able to snorkel. This activity take 5 minutes, so get ready. \n\nPress 'enter' when you are ready? \n> ");
        _start.Add("Welcom to the REFLECTING ACTIVITY! \n\nIn this activity, you will be givin a couple of deep questions to get you thinking. \n\nHow long in seconds would you like to reflec for? \n> ");
        _start.Add("Welcom to the BRAINSTORMING ACTIVITY! \n\nThis activity it desinged to help you brain storm.\nYou will be givin a prompt.\nList as many responses to that prompt as you can with ths time you give. \n\nHow long would you like to list for? \n> ");
        string activityString = " ";
        if (i == 1)
        {
            activityString = _start[0];
        }
        if (i == 2)
        {
            activityString = _start[1];
        }
        if (i == 3)
        {
            activityString = _start[2];
        }

        return activityString;

    }
    public void RLineTwo(int i, int aName)
    {
        string activityName = "";
        if (aName == 1)
        {
            activityName = "Breathing";
        }
        if (aName == 2)
        {
            activityName = "Reflecting";
        }
        if (aName == 3)
        {
            activityName = "Listing";
        }
    
        Console.WriteLine($"\nYou have completed another {i} seconds of the {activityName} Activity\n\n");
    }

    public void RLineOne()
    {
        Console.WriteLine("Well Done!!");
    }
}