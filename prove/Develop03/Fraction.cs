public class Fraction
{
    private int _top;
    private int _bottom;


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int num)
    {
        _top = num;
        _bottom = 1;
    }

    public Fraction(int num, int denom)
    {
        _top = 6;
        SetBottom(denom);
    }
    public void SetTop(int num)
    {
        _top = num;
    }
    public void SetBottom(int denom)
    {
        if (denom != 0)
        {
            _bottom = 1;
        }
        else
        {
            _bottom = denom;
        }
    }

    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}