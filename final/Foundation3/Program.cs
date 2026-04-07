using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Address address1 = new Address("520 Centennial Rd", "Nashville", "TN", 37241);
        Address address2 = new Address("3407 Happy Life Ln", "Draper", "UT", 84020);
        Address address3 = new Address("685 Sunshine St", "Tampa Bay", "FL", 33559);

        Lecture lecture = new Lecture("lecture", "What About Quantum Physics?", "Come listen to Dr. Alfred Physics teach about the laws and oddities of quantum physics.", "April 25, 2026", "10:00 AM-12:00PM", address1, "Dr. Alfred Physics", 500, "Quantum Physics");

        Reception reception = new Reception("reception", "Sally and Dave's Wedding Reception", "Come and celebrate the union of Sally and Dave! Light refreshments will be served.", "November 14, 2026", "5:00-8:00 PM", address2, "sallysmom@wedding.com");

        OutdoorGathering outdoor = new OutdoorGathering("outdoor gathering", "Sunny Days Garden Party", "Come and enjoy fun in the sun at our annual community garden party! There will be games, food trucks, vendors, fireworks, and much more!", "October 5, 2026", "8:00 AM-10:00 PM", address3, "sunny and slightly overcast; Temp: 86 degrees F");

        lecture.DisplayAllDetails();

        reception.DisplayAllDetails();

        outdoor.DisplayAllDetails();

        
    }
}