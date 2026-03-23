class Load
{

    string path = "";

    private List<Stored> entrys = new List<Stored>();

    public Load() {}
    public void LoadFile()
    {
        Console.WriteLine("Enter the name of the txt file:");
        path = Console.ReadLine();

        if (File.Exists(path))
        {
            Stored.Clear();
            string[] lines = File.ReadAllLines(path);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Stored newEntry = new Stored();
                    newEntry._randomPrompt = parts[1];
                    newEntry._userInput = parts[2];
                    entrys.Add(newEntry);
                }
            }
        }
        else 
        {
            Console.WriteLine("File not found!");
        }
    }

    public void SaveFile()
    {
        Console.WriteLine("Enter the name of the txt file:");
        path = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(path))
        {
            foreach (Entry e in entrys)
            {
                outputFile.WriteLine($"{e.today.ToShortDateString()}|{e._randomPrompt}|{e._userInput}");
            }
        }
    }




}