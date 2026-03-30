public class Address : Event
{
    private List<string> _addresses = new List<string>();

    public Address()
    {
        _addresses.Add("Fairground DR, Pocatello, ID 83201");
        _addresses.Add("32 College Ave, Rexburg, ID 83440");
        _addresses.Add("4629 E 100 Rd N, Rigby, ID 83442");
    }

    public string GetAddress(int index)
    {
        string address = _addresses[index];
        return address;

    }
}