using System;

class Program
{
    static void Main(string[] args)
    {
       Info i = new Info();
       i.SetEvent("Bannak Firework Show", "Come see the incredible 30 minute firework show that will blow your socks off!!!", "July 4, 2026", "8:30 pm");
       Console.Clear();

       Console.WriteLine("===============================");
       i.Standard();
       i.DisplayAddress(0);
       Console.WriteLine("===============================");
       i.SetType("Outdoor gathering");
       i.RunInfo();
       Console.WriteLine("===============================");
       i.ShortDescription();
       Console.WriteLine("\n");

        Console.WriteLine("===============================");
        Console.WriteLine("          Other Event          ");
        Console.WriteLine("===============================");


       Info i2 = new Info();
       i2.SetEvent("Comidy Skit", "Are you ready to laugh? You better be when you come see this famous comidian perform!!", "October 2, 2026", "10:30 pm");
        Console.WriteLine("\n");
       Console.WriteLine("===============================");
       i2.Standard();
       i2.DisplayAddress(1);
       Console.WriteLine("===============================");
       i2.SetType("Lectures");
       i2.RunInfo();
       Console.WriteLine("===============================");
       i2.ShortDescription();
       Console.WriteLine("\n");


       Console.WriteLine("===============================");
        Console.WriteLine("          Other Event          ");
        Console.WriteLine("===============================");


       Info i3 = new Info();
       i3.SetEvent("Porter's and Anna's Wedding", "Bring your dance pance and a hungry stomach to celibration to comming of two families", "Augest 12, 2028", "6:30 pm");
        Console.WriteLine("\n");
       Console.WriteLine("===============================");
       i3.Standard();
       i3.DisplayAddress(2);
       Console.WriteLine("===============================");
       i3.SetType("Lectures");
       i3.RunInfo();
       Console.WriteLine("===============================");
       i3.ShortDescription();
    }


}