using System.Diagnostics.Contracts;
using System.Net;

public class Word
{
    private string _word;
    private string _blank;
    private string _show;
    private int _count = 0;

    public Word(string aWord)
    {
        _word = aWord;
        // for (_blank = ""; _blank.Length < aWord.Length; _blank += "_")
        // {
            
        // }
        _blank = "";
        for (int i = 1; i <= aWord.Length; i++)
        {
            _blank += "_";
        }
        _show = _word + " ";
    }

   public bool IsBlank()
{
    return _show.Trim() == _blank;
}

    public void GoBlank()
    {
        _show = _blank + " ";

        _count += 1;

    }

    public string GetShows()
    {
        return _show;
    }


}


