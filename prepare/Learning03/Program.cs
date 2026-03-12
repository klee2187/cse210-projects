using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
    
        Fraction fraction1 = new Fraction();

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Random random = new Random();
        Fraction fraction5 = new Fraction();
        for (int index = 0; index < 20; index++)
        {
            int topValue = random.Next(1, 11);
            int bottomValue = random.Next(1, 11);
            fraction5.SetTopNum(topValue);
            fraction5.SetBottomNum(bottomValue);
            Console.Write($"(Fraction {index + 1}: ");
            Console.Write($"string: {fraction5.GetFractionString()}");
            Console.WriteLine($" Number: {fraction5.GetDecimalValue()}"); 
        
        }
    }
}