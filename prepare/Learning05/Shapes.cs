public abstract class Shapes
{
    protected string _color;

    public Shapes(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        string color = _color;
        return color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    abstract public double GetArea();
    
}