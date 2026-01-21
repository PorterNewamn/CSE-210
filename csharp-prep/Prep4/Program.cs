using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {

        List<int> count = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a Number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                count.Add(userNumber);
            }
        }

        int sum = 0;
        int numberCount = 0;
        foreach (int number in count)
        {
            sum += number;
            numberCount += 1;

        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numberCount;
        Console.WriteLine($"The Average is: {average}");
        
        int max = 0;
        foreach (int number in count)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The Largest Number is: {max}");
    }
}