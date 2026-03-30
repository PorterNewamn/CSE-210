public class Activity
{
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
}