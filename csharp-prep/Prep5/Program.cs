using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredUser = SquareNumber(number);
        int userAge;
        PromtUserBirthYear(out userAge);

        DisplayResult(name, squaredUser, userAge);


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!!!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorit number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;

    }
    static int PromtUserBirthYear(out int userAge)
    {
        Console.Write("Enter the year you were born: ");
        userAge = int.Parse(Console.ReadLine());

        return userAge;
    }
    static int SquareNumber(int userNumber)
    {
        int squared = userNumber * userNumber;

        return squared;
    }
    static void DisplayResult(string name, int squaredUser, int userAge)
    {
        Console.WriteLine($"{name}, the quare of your number is {squaredUser}");
        Console.Write($"{name}, you will be terning {2026 - userAge} this year!");
    }
}

