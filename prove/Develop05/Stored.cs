using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Stored
{
    private List<Goal> _storeGoal = new List<Goal>();
    private List<int> _points = new List<int>();
    private List<string> _checkBox = new List<string>();
    private int _pontsEarned = 0;

    public Stored() {}


    public List<Goal> GetGoalList() => _storeGoal;
    public List<string> GetCheckBoxList() => _checkBox;



    
    public void DisplayGoals()
    {
        for (int i = 0; i < _storeGoal.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_checkBox[i]} {_storeGoal[i].DisplayGoal()}");
        }
    }

    public void DisplayPoints()
    {
        Console.WriteLine($"\n You have {_pontsEarned} Points.\n");
    }

    public Goal CreatGoal()
    {
        bool keepAsking = true;
        while (keepAsking == true)
        {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("  1) Short Goal");
            Console.WriteLine("  2) Eternal Goal");
            Console.WriteLine("  3) List Goal");
            Console.Write("Which goal would you like to create: ");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Goal g = new Goal();
                g.InputGoal();
                _storeGoal.Add(g);
                _points.Add(g.GetPointVal());
                _checkBox.Add("[ ]");
                return g;
            }
            else if (userInput == "2")
            {
                Goal e = new Eternal();
                e.InputGoal();
                _storeGoal.Add(e);
                _points.Add(e.GetPointVal());
                _checkBox.Add("[ ]");
                return e;
            }
            else if (userInput == "3")
            {
                Goal lg = new ListGoal();
                lg.InputGoal();
                _storeGoal.Add(lg);
                _points.Add(lg.GetPointVal());
                _checkBox.Add("[ ]");
                return lg;
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }
        }
        return null;
    }

    public void RecordEvent()
    {
        DisplayGoals();
        
        Console.Write("\nEnter the number you wan't to check off: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal selectedGoal = _storeGoal[index];
        selectedGoal.RecordProgress();

        int pointsEarned = selectedGoal.GetPointVal();
        _points.Add(pointsEarned);

        Console.WriteLine($"Congrats! you have earned {pointsEarned}");

        if (selectedGoal.Check())
        {
            _checkBox[index] = "[X]";
            _pontsEarned = _points[index];

        }
    }

}