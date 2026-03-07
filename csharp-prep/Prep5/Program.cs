using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squaredNum = SquareNumber(userNum);

        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squaredNum, birthYear);

    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
    
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int favNumber = int.Parse(Console.ReadLine());

            return favNumber;
        }

        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write("What is your birthyear? ");
            birthYear = int.Parse(Console.ReadLine());

        }

        static int SquareNumber(int favNumber)
    {
            int squared = favNumber * favNumber;
            return squared;
    }

        static void DisplayResult(string name, int squared, int birthYear)
    {
            Console.WriteLine($"{name}, the square of your number is {squared}");
            Console.WriteLine($"{name}, you will turn {2026 - birthYear} this year.");
    }

    
}