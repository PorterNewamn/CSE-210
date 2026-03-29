public class Coustomer
{
    private string _name;

    public Coustomer(){}
    public List<Address> _address = new List<Address>();

    public void SetName(string name)
    {
        _name = name;
    }
    public void DisplayCustAddress()
    {
        Console.WriteLine($"Name: {_name}");
        Console.Write("Adrress: ");

        foreach (Address a in _address)
        {
            a.ShowAdrress();
        }
    }


}