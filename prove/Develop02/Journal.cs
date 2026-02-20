

using System.IO;
using System.Runtime.InteropServices.Marshalling;
public class Journal
{

    string path = " ";
    public List<Entry> entrys = new List<Entry>();


    public void AddEntry(Entry entry)
    {
        entrys.Add(entry);
    }

    public void Display()
    {
        foreach (var i in entrys)
        {
            i.Display();
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

    public void LoadFile()
    {
        Console.WriteLine("Enter the name of the txt file:");
        path = Console.ReadLine();

        if (File.Exists(path))
        {
            entrys.Clear();
            string[] lines = File.ReadAllLines(path);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry newEntry = new Entry();
                    newEntry.today = DateTime.Parse(parts[0]);
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
}

