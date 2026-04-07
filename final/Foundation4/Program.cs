using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Running run = new Running(40, "16 Jun 2023", 5.0m, 4.8m, 5.7m);

        IndoorBiking bike = new IndoorBiking(25, "01 Feb 2026", 6.4m, 3.0m, 4.5m);

        Swimming swim = new Swimming(60, "12 Mar 1999", 3.4m, 5.4m, 4.8m, 25);

        run.GetSummary();
        bike.GetSummary();
        swim.GetSummary();
    }
}