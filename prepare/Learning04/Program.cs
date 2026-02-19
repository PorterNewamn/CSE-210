using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        English e = new English();
        e.SetTitle("The Causes of World War II by Mary Waters");
        Console.WriteLine(e.GetInfo());
        Console.WriteLine(e.GetWritingInformation());

        Math m = new Math();
        m.SetText("7.3", "8-19");
        Console.WriteLine(m.GetInfo());
        Console.WriteLine(m.GetHomeworkList());
    }
}