using System.Dynamic;
using System.Xml.Serialization;

public class Product
{
    private int _quantity;
    private string _product;
    private double _price;
    private int _product_id;
    private double _cost;

    public Product(){}

    public void SetProduct(string product, double price, int quantity, int product_id)
    {
        _quantity = quantity;
        _product = product;
        _price = price; 
        _product_id = product_id;
    }

    public void ProductLable()
    {
        Console.WriteLine($"Product ID:{_product_id} | {_product} ${_cost} --- qant: {_quantity}");
    }

    public void CalcCost()
    {
        _cost = _quantity * _price;
    }
    
    public double GetTotalCost()
{
    return _cost;
}

}