using System;
using System.ComponentModel.Design;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        BreathingActivity ba = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity ra = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity la = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        StretchingActivity sa = new StretchingActivity("Stretching", "This activity will help you relax your body and mind by guiding you through simple, gentle stretches.");

        bool quit = false;
        while (!quit)
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Mindfulness Program!\n");

            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Stretching Activity");
            Console.WriteLine("5. Quit");

            Console.Write("\nSelect an activity: ");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":

                    ba.InitiateBreathingActivity();
                    break;

                case "2":

                    ra.InitiateReflectionActivity();
                    break;

                case "3":

                    la.InitiateListingActivity();
                    break;

                case "4":

                    sa.InitiateStretchingActivity();
                    break;

                case "5":
                    Console.WriteLine("Good job pausing to be mindful today! Goodbye :)");
                    quit = true;
                    break;
            }
        }
    }
}