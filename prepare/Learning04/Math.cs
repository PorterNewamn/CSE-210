public class Math : Assignments
{
    private string _textbookSection = " ";
    private string _problems = " ";
    Assignments a = new Assignments();

    public void SetText(string textbook, string problem)
    {
        _textbookSection = textbook;
        _problems = problem;
        a.SetSummery("Roberto Rodriguez","Fractions");
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problem {_problems}";
    }

    public string GetInfo()
    {
        return a.GetSummery();
    }
}