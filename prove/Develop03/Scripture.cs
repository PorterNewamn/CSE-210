public class Scripture
{
    private List<Word> _script = new List<Word>();
    private string _reference;
    private int _wordCount;
    List<int> isBlank = new List<int>();
    Random random = new Random();
    string reference = " ";
    public Scripture()
    {
        string memorize = "Jacob 2:18-19 - But before ye seek for riches, seek ye for the kingdom of God. And after ye have obtained a hope in Christ ye shall obtain riches if ye seek them and ye will seek them for the intent to do good—to clothe the naked and to feed the hungry, and to liberate the captive and administer relief to the sick and the afflicted.";
        string [] space = memorize.Split(" - ");
        string referanceString = space[0];
        string scriptureString = space[1];
        string [] riches = scriptureString.Split(" ");
        _reference = referanceString;

        foreach (string i in riches)
        {
            _script.Add(new Word(i));
        }
    }
    public string GetRef()
    {
        reference = _reference;
        return reference;
    }

    public string GetList()
    {
        string shownWords = "";
        foreach (Word word in _script)
        {
            shownWords += word.GetShows();
        }
        return shownWords;
    }

    public void SetBlank()
    {
        isBlank.Clear();

        for (int i = 0; i < _script.Count; i++)
        {
            if (!_script[i].IsBlank())
            {
                isBlank.Add(i);
            }
        }

        if (isBlank.Count > 0)
        {
            
            int choice = random.Next(0, isBlank.Count);
            int hideIndex = isBlank[choice];

            _script[hideIndex].GoBlank();
        }

        _wordCount -= 1;
    }
    public bool HiddenAllWords()
    {
        foreach (Word word in _script)
        {
            if (!word.IsBlank())
            {
                
                return false;
            }
        }
        
        return true;
    }

    public void SetWordCount()
    {
        _wordCount = 63;
    }    

    public string WordCount()
    {
        return $"\nWords Remaining are [{_wordCount}]";
    }
}