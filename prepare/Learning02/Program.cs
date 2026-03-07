using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

            Job job1 = new Job();
            job1._jobTitle = "Software Engineer";
            job1._company = "Google";
            job1._startYear = "";
            job1._endYear = "2011";

            Job job2 = new Job();
            job2._jobTitle = "Receptionist";
            job2._company = "West Construction Inc.";
            job2._startYear = "2019";
            job2._endYear = "2025";

            Job job3 = new Job();
            job3._jobTitle = "Construction Worker";
            job3._company = "Faber Work";
            job3._startYear = "1999";
            job3._endYear = "2010";

            Job job4 = new Job();
            job4._jobTitle = "Corporate Sales Coordinator";
            job4._company = "Uline";
            job4._startYear = "2015";
            job4._endYear = "2020";

            Resume resume = new Resume();
            resume._firstName = "Kristen";
            resume._lastName = "Lee";

            resume._jobs.Add(job1);
            resume._jobs.Add(job2);
            resume._jobs.Add(job3);
            resume._jobs.Add(job4);

            resume.DisplayResume();

            
    }
    
}