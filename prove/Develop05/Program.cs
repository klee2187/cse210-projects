using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        List<Goal> goals = new List<Goal>();
        string stage = "Seed";
        int neededPts = 500;
        int totalPts = 0;

        void CheckStage()
        {
            if (totalPts < 1000)
            {
                stage = "Seed";
            }
            else if (totalPts >= 1000 && totalPts < 2000)
            {
                stage = "Sprout";
            }
            else if (totalPts >= 2000 && totalPts < 3000)
            {
                stage = "Young Shoot";
            }
            else if (totalPts >= 3000 && totalPts < 4000)
            {
                stage = "Sapling";
            }
            else if (totalPts >= 4000)
            {
                stage = "Evergreen";
            }
        }

        void PointsNeeded()
        {
            if (stage == "Seed")
            {
                neededPts = 1000 - totalPts;
            }
            else if (stage == "Sprout")
            {
                neededPts = 2000 - totalPts;
            }
            else if (stage == "Young Shoot")
            {
                neededPts = 3000 - totalPts;
            }
            else if (stage == "Sapling")
            {
                neededPts = 4000 - totalPts;
            }
            else if (stage == "Evergreen")
            {
                neededPts = 5000 - totalPts;
            }
        }

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Welcome to the Eternal Quest Program!");
            Console.WriteLine($"You are now a {stage}. Complete goals and earn points to grow!\n");

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("\nPlease choose an action: ");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":

                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string choose = Console.ReadLine();

                    if (choose == "1")
                    {
                        SimpleGoal simple1 = new SimpleGoal("", "", 0);
                        simple1.GetDetails();
                        goals.Add(simple1);

                    }

                    else if (choose == "2")
                    {
                        EternalGoal eternal1 = new EternalGoal("", "", 0);
                        eternal1.GetDetails();
                        goals.Add(eternal1);
                    }

                    else if(choose == "3")
                    {
                        ChecklistGoal check1 = new ChecklistGoal("", "", 0, 0, 0);
                        check1.GetDetails();
                        goals.Add(check1);
                    }
                            
                    else
                    {
                        Console.WriteLine("That is an invalid choice, please try again.");
                    }

                    break;

                case "2":

                    int count = 1;
                    Console.WriteLine("Here are your goals:");
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine($"{count}. {goal.GoalString()}");
                        count++;
                    }
                    Console.WriteLine();

                    break;

                case "3":
                
                    Console.Write("What file would you like to save your goal to? ");
                    string userFile = Console.ReadLine();
            
                    using (StreamWriter outputFile = new StreamWriter(userFile))
                    {
                        outputFile.WriteLine($"You have {totalPts} points. You are currently a {stage}, you need {neededPts} points to grow to the next stage.");
                        foreach (Goal goal in goals)
                        {
                            outputFile.WriteLine(goal.GetStringRepresentation());
                        }
                    }
                    break;

                case "4":

                    Console.Write("Please enter your file name: ");
                    userFile = Console.ReadLine();

                    string[] lines = System.IO.File.ReadAllLines(userFile);

                    foreach (string line in lines)
                    {   
                        if (line.StartsWith("You have"))
                            continue;

                        string[] parts = line.Split(":");

                        string type = parts[0];
                        string elem = parts[1];

                        string[] items = elem.Split(",");

                        if (type == "SimpleGoal")
                        {
                            string name = items[0];
                            string description = items[1];
                            int points = int.Parse(items[2]);

                            SimpleGoal g = new SimpleGoal(name, description, points);
                            goals.Add(g);
                        }
                        else if (type == "EternalGoal")
                        {
                            string name = items[0];
                            string description = items[1];
                            int points = int.Parse(items[2]);

                            EternalGoal g = new EternalGoal(name, description, points);
                            goals.Add(g);
                        }
                        else if (type == "ChecklistGoal")
                        {
                            string name = items[0];
                            string description = items[1];
                            int points = int.Parse(items[2]);
                            int bonus = int.Parse(items[3]);
                            int completed = int.Parse(items[4]);
                            int target = int.Parse(items[5]);

                            ChecklistGoal g = new ChecklistGoal(name, description, points, target, bonus);
                            g.SetNumCompleted(completed);
                            goals.Add(g);
                        }
                    }

                    break;

                case "5":
                    
                    count = 1;
                    Console.Write("What type of goal did you accomplish? ");
                    foreach (Goal goal in goals)
					{
						Console.WriteLine($"{count}. {goal.GoalString()}");
                    	count++;
					}
					
					int index = int.Parse(Console.ReadLine());
					if (index > goals.Count || index <= 0)
					{
						Console.WriteLine($"Choose a number between 1 and {goals.Count}.");
					}
					else 
					{
						index = index - 1;
						int earnedPoints = goals[index].RecordEvent();
						totalPts += earnedPoints;
						Console.WriteLine($"Hooray! You have earned {earnedPoints} points!");
						Console.WriteLine($"You now have {totalPts} points. Great job!");
						CheckStage();
						PointsNeeded();
						Console.WriteLine();
					}
                    break;
                
                case "6":
                    Console.WriteLine("Thank you for tracking your goals with us today! See you soon! :)");
                    quit = true;
                    break;
            }
        }
    }
}