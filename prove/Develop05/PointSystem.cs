public class PointSystem
{
    string stage = "Seed";
    int neededPts = 500;
    int totalPts = 0;

    public void CheckStage()
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
    public void pointsNeeded()
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

    public void DisplayLevels()
    {
        Console.WriteLine($"You are now a {stage}. You need {neededPts} more points to grow to the next stage.\n");
    }
}