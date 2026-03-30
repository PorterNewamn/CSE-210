using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Stored s = new Stored();
        Load l = new Load();
        Console.Clear();
        Activity a = new Activity();
    
        string keepRunning = "run";
        a.Animation(2);
        Console.WriteLine("Welcom to Goal Creator");
        while (keepRunning != "stop")
        {
            s.DisplayPoints();
            Console.WriteLine("Menu:");
            Console.WriteLine(" 1. Creat New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Record Event");
            Console.WriteLine(" 4. Save to File");
            Console.WriteLine(" 5. Load Goal");
            Console.Write("Select a Choice from the menu: ");
            keepRunning = Console.ReadLine();
            if (keepRunning == "1")
            {
                a.Animation(2);
                Goal goal = s.CreatGoal();
                a.Animation(2);
            }
            else if (keepRunning == "2")
            {
                a.Animation(1);
                s.DisplayGoals();
            }
            else if (keepRunning == "3")
            {
                a.Animation(3);
                s.RecordEvent();
                a.Animation(2);
            }
            else if (keepRunning == "4")
            {
                a.Animation(6);
                Console.Write("Enter the NAME of the text file you would like to save your Goals to: ");
                string textFilie = Console.ReadLine();
                l.SetPath(textFilie);
                l.SaveGoals();
                Console.WriteLine($"Goal Saved to File ({textFilie}).");
                a.Animation(2);
            }
            else if (keepRunning == "5")
            {
                a.Animation(6);
                l.LoadGoals();
                Console.WriteLine("Loaded Successful!");
                a.Animation(3);
            }
            else if (keepRunning == "6")
            {
                a.Animation(2);
                Console.Clear();
                Console.WriteLine("GOOD BYE!");
                break;
            }
            else
            Console.WriteLine("Invalid input, Please enter a different input");
        }
        

    }
}