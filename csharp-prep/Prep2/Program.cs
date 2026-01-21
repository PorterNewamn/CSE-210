using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeFromUser = Console.ReadLine();
        int grade = int.Parse(gradeFromUser);
        string letterOfGrade = "";

        if (grade >= 90)
        {
            letterOfGrade = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letterOfGrade = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letterOfGrade = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letterOfGrade = "D";
        }
        else
        {
            letterOfGrade = "F";
        }

        Console.Write($"You recived a {letterOfGrade}.");

        if (grade >= 70)
        {
            Console.Write("\nCongradulations!!! You Passed!!!");
        }
        else
        {
            Console.Write("\nI'm Sorry... You Need to Take the Corse Again :(");
        }
    }
}