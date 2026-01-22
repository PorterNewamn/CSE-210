public class Job
{
    public string _jobDiscription;
    public string _jobTitle;
    public string _companyName;
    public int _startYear;
    public int _endyear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} for company ({_companyName}) {_startYear}-{_endyear} ");
    }

}