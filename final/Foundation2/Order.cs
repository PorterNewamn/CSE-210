using System.Reflection.Metadata;

class Order
{
    private List<Product> _products = new List<Product>();
    private Coustomer _customer;

    public Order(Coustomer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void PrintShippingLable()
    {
        _customer.DisplayCustAddress();
        _customer._address[0].ShippingFee();
    }

    public void PackingLabel()
    {
        double totalOrderCost = 0;
        foreach (Product p in _products)
        {
            p.CalcCost();
            p.ProductLable();
            totalOrderCost += p.GetTotalCost();
        }

        Console.WriteLine("---------------------------");
        Console.WriteLine($"Total Order Price: ${totalOrderCost:F2}");
    }











}