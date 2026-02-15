using System;
class Program 
{
    static void Main(string[] args)
    {
        Journal paper = new Journal();
        
        string userInpute = "0";

        while (userInpute != "quit")
        {
            Console.WriteLine("Please select one of the folling choises: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            userInpute = Console.ReadLine();

            if (userInpute == "1")
            {
                Entry entry = new Entry();
                entry.responsDisplay();
                paper.AddEntry(entry);
            }
            else if (userInpute == "2")
            {
               paper.Display();

            }

            else if (userInpute == "3")
            {
                
            }

            else
            {
                userInpute = "quit";
            }
        }
        Console.WriteLine("Thanks, Journal again soon!")
    }
}