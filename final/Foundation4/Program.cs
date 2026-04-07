using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Running run = new Running(45, "16 Jun 2023", 6.2m, 8.1m, 7.5m);

        IndoorBiking bike = new IndoorBiking(30, "01 Feb 2026", 10.5m, 20.0m, 3.3m);

        Swimming swim = new Swimming(30, "12 Mar 1999", 2.4m, 4.4m, 14.8m, 40);

        run.GetSummary();
        bike.GetSummary();
        swim.GetSummary();
    }
}