public class Load
{
    
    private string _path = " ";
    public List<Goal> goals = new List<Goal>();

    public Load() {}

    public void SetPath(string path)
    {
        _path = path;
    }
    
    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter(_path))
        {
            Stored s = new Stored();
            outputFile.WriteLine(s.GetPoints());
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine($"{goal.GetGoal()}|{goal.Check()}");
            }
        }
    }

    public List<Goal> LoadGoals()
    {
        List<Goal> loadedGoals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(_path);
        for (int i = 1; i < lines.Length; i++) 
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool isComplete = bool.Parse(parts[4]);

            Goal newGoal;
            if (type == "Eternal")
            {
                newGoal = new Eternal();
            }
            else
            {
                newGoal = new Goal();
            }
            loadedGoals.Add(newGoal);
        }
        return loadedGoals;
    }
}