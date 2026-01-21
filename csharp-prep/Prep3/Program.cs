using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 1001);

        Console.WriteLine("A Random Number has Been Generated");
        Console.WriteLine("Guess a number from 1-1,000");

        int guess = -1;

        while (guess != number)
        {    
            Console.Write("What is your Guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess < number)
            {
                Console.WriteLine("Guess a Higher Number!");
            } 
            else if (guess > number)
            {
                Console.WriteLine("Guess a Lower Number!");
            }
            else
            {
                Console.WriteLine("GREAT JOB!!! YOU GUESSED THE NUMBER!!!");
            }
        }

        

    }
}