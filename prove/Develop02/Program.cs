using System;
using System.Runtime.InteropServices.Marshalling;
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
                paper.LoadFile();
            }
            else if (userInpute == "4")
            {
                paper.SaveFile();
                Console.WriteLine("Entry Saved");
            }
            else if (userInpute == "5")
            {
                userInpute = "quit";
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
        Console.WriteLine("Thanks, Journal again soon!");
    }
}