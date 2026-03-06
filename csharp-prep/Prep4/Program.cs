using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers (type 0 when finished)");

        int inputNumber = -1;

        while (inputNumber != 0) 
        {
            Console.Write("Enter Number: ");
            string listNumber = Console.ReadLine();

            inputNumber = int.Parse(listNumber);

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }

        }

        int total = 0; 
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum is: {total}");

        float avg = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        double? minPositive = null;

        foreach (double number in numbers)
        {
            if (number > 0 && (minPositive == null || number < minPositive))
            {
                minPositive = number;
            } 
        }

        Console.WriteLine($"The smallest positive number is: {minPositive}");

        numbers.Sort();
        Console.WriteLine("Sorted List: " + string.Join(", ", numbers));
        
    }
}