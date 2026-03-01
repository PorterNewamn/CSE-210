using System;

class Program
{
    static void Main(string[] args)
    {
        Listing l = new Listing();
        Breath b = new Breath();
        Reflection r = new Reflection();

        string userInput = "";

        Console.Clear();
        Console.WriteLine("Welcom to the Meditation Center");
        while (userInput != "4")
        {
            Console.WriteLine("Menu Option:");
            Console.WriteLine($"    1) Start Breathing Holding Exercise");
            Console.WriteLine($"    2) Start Adventure Reflection");
            Console.WriteLine($"    3) Start Brain Stroming Activity");
            Console.WriteLine($"    4) Quit");
            Console.WriteLine($"Select a choice from the menu:");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
               b.RunBreath();
            }
            else if (userInput == "2")
            {
                r.RunListing();
            }
            else if (userInput == "3")
            {
                l.RunListing();
            }
            else if (userInput == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Sorry Invalid Respons, Please try again.");
            }

            
        }
        Console.Clear();
        Console.WriteLine("Thanks, Come again!");
    }
}