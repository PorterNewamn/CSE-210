using System.Reflection;

public class English : Assignments
{
    private string _title = " ";
    Assignments a = new Assignments();

    public void SetTitle(string title)
    {
        a.SetSummery("Mary Waters","European History");
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title}";
    }
    public string GetInfo()
    {
        return a.GetSummery();
    }
}