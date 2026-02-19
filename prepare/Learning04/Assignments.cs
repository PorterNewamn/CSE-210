public class Assignments
{
    private string _studentName;
    private string _topic;

    public string GetSummery()
    {
        return $"{_studentName} - {_topic}";
    }

    public void SetSummery(string student, string topic)
    {
        _studentName = student;
        _topic = topic;
    }

}