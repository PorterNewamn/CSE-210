

using System.IO;
public class Journal
{

    string path = @"PrivateJournal.txt";
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
    
}

