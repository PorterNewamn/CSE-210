using System.IO.Compression;

public class Address
{
    private string _city;
    private int _zip;
    private string _country;
    private string _street;
    private string _state;
    private int _fee;

    public Address(){}

    public void SetAdrress(string street, string city, string state, int zip, string country)
    {
        _city = city;
        _zip = zip;
        _country = country;
        _street = street;
        _state = state;
    }

    public void ShowAdrress()
    {
        Console.WriteLine($"{_street}, {_city}, {_state}, {_zip}, {_country}");
    }

    public void ShippingFee()
    {
        if (_state == "USA")
        {
            _fee = 5;
        }
        else
        {
            _fee = 35;
        }
        Console.WriteLine($"    Your Shipping Fee is ${_fee}");
    }


}