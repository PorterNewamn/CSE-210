using System.ComponentModel.Design.Serialization;

class Comments
{
    public string _name;
    public string _comment;
    List<string> _commentsInfo = new List<string>();

    public void AddComments()
    {
        _commentsInfo.Add($"{_name} left a comment saying {_comment}");
    }

    public void DisplayCommentInfo()
    {
        foreach (string comments in _commentsInfo)
        {
            Console.WriteLine(comments);
        }
    }
}