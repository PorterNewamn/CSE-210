public class Reference
{
    private string _referal;

    public string Refer()
    {       
        Scripture s = new Scripture();
        _referal = s.GetRef();
        string refer = _referal;
        return refer;
    }

}