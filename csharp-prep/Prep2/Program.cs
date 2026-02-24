using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage (write number 0-100)? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >=70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        string sign = "";
        int lastDigit = percentage % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        if (letter == "F")
        {
            sign ="";
        }
        else if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is a/an {sign}{letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Hooray! Great job, you passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass this time, but you can do it if you work hard and try again!");
        }
    }
}