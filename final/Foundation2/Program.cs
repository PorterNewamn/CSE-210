using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Coustomer c1 = new Coustomer();
        c1.SetName("Bill Jane");
        Address a1 = new Address();
        a1.SetAdrress("9732 N 70th E", "Idaho Falls", "ID", 83401, "USA");
        c1._address.Add(a1);
        Order userOrder = new Order(c1);
        Product p1 = new Product();
        p1.SetProduct("JBL Speaker", 29.99, 2, 10001);
        userOrder.AddProduct(p1);
        Product p2 = new Product();
        p2.SetProduct("HDMI Cable", 15.50, 1, 10002);
        userOrder.AddProduct(p2);
        Console.WriteLine("--- Packing Label ---");
        userOrder.PackingLabel();
        Console.WriteLine("\n--- Shipping Label ---\n");
        userOrder.PrintShippingLable();


        Console.WriteLine("\n");
        Coustomer c2 = new Coustomer();
        c2.SetName("Porter Newman");
        Address a2 = new Address();
        a2.SetAdrress("3118 Birch  Street", "El Paso", "TX", 79915, "USA");
        c2._address.Add(a2);
        Order userOrder2 = new Order(c2);
        Product p3 = new Product();
        p3.SetProduct("Quick Draws", 89.89, 2, 10012);
        userOrder2.AddProduct(p3);
        Product p4 = new Product();
        p4.SetProduct("#3 Cam", 122.89, 3, 10043);
        userOrder2.AddProduct(p4);
        Product p5 = new Product();
        p5.SetProduct("#0.75 Cam", 83.72, 2, 10677);
        userOrder2.AddProduct(p5);
        Console.WriteLine("--- Packing Label ---");
        userOrder2.PackingLabel();
        Console.WriteLine("\n--- Shipping Label ---\n");
        userOrder2.PrintShippingLable();
        
        Console.WriteLine("\n");
        Coustomer c3 = new Coustomer();
        c3.SetName("Anna Elliott");
        Address a3 = new Address();
        a3.SetAdrress(" 17, Narayan Pillai Street", "Bengaluru", "Karnataka", 560001, "Russia");
        c3._address.Add(a3);
        Order userOrder6 = new Order(c3);
        Product p6 = new Product();
        p3.SetProduct("Hat", 8.99, 1, 20100);
        userOrder2.AddProduct(p6);
        Product p7 = new Product();
        p4.SetProduct("Beard Trimer", 29.99, 1, 10072);
        userOrder2.AddProduct(p7);
        Product p8 = new Product();
        p5.SetProduct("Cat Food", 12.98, 2, 10457);
        userOrder2.AddProduct(p8);
        Console.WriteLine("--- Packing Label ---");
        userOrder2.PackingLabel();
        Console.WriteLine("\n--- Shipping Label ---\n");
        userOrder2.PrintShippingLable();
    }
}