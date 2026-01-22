public class Resume
{
    public string _firstNameOfImployer;
    
public List<Job> _job = new List<Job>();



    
    public void Display()
    {
        Console.WriteLine($"Name: {_firstNameOfImployer}");
        Console.WriteLine("Job: ");

        foreach (Job catigory in _job)
        {
            catigory.Display();
        }
    }
}