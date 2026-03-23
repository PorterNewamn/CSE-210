using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Stored s = new Stored();
        Console.Clear();
        string keepRunning = "run";
        Console.WriteLine("Welcom to Goal Creator");
        while (keepRunning != "stop")
        {
            s.DisplayPoints();
            Console.WriteLine("Menu:");
            Console.WriteLine(" 1. Creat New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Record Event");
            Console.Write("Select a Choice from the menu: ");
            keepRunning = Console.ReadLine();
            if (keepRunning == "1")
            {
                Goal goal = s.CreatGoal();
                
            }
            else if (keepRunning == "2")
            {
                s.DisplayGoals();
            }
            else if (keepRunning == "3")
            {
                s.RecordEvent();
            }
            else if (keepRunning == "6")
            {
                break;
            }
            else

            Console.WriteLine("Invalid input, Please enter a different input");
        }
        

    }
}