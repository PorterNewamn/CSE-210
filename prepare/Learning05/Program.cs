using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shape = new List<Shapes>();
       
        Square s1 = new Square("red", 3);
        shape.Add(s1);

        Rectangle r1 = new Rectangle("blue", 4, 5);
        shape.Add(r1);

        Circle c1 = new Circle("purple", 10);
        shape.Add(c1);

        Console.Clear();
        foreach (Shapes s in shape)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            if (area % 1 != 0)
            {
                Console.WriteLine($"\nThe {color} shape has an radius of {area}!");
            }
            else
            {
                Console.WriteLine($"\nThe {color} shape has an area of {area}!");
            }

        }

        Console.WriteLine("");

    }
}