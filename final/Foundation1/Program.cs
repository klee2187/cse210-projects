using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video();
        video1._title = "How to Make Chocolate Chip Cookies using a Kitchen-Aid";
        video1._author = "CookieLover13";
        video1._length = 420;
        video1.NumComments();

        Comment video1Comment1 = new Comment();
        video1Comment1._commenter = "ILoveToBake";
        video1Comment1._text = "Great video! My family loved these cookies. I will need one of those Kitchen-Aids! Looks WAY easier!";

        Comment video1comment2 = new Comment();
        video1comment2._commenter = "Karen FoodCritic";
        video1comment2._text = "Ugh, why can't people just make cookies the old fashioned way? With elbow grease!";

        Comment video1comment3 = new Comment();
        video1comment3._commenter = "Mr. Gadget";
        video1comment3._text = "I think my wife needs one of these...";
        
        Video video2 = new Video();
        video2._title = "Kitchen-Aid Shredded Chicken - Quick and Easy!";
        video2._author = "Bill TimeSaver";
        video2._length = 135;
        video2.NumComments();

        Comment video2Comment1 = new Comment();
        video2Comment1._commenter = "Dan Lund";
        video2Comment1._text = "That was quick!";

        Comment video2Comment2 = new Comment();
        video2Comment2._commenter = "Gary Griller";
        video2Comment2._text = "Where do I get one of these??";

        Comment video2Comment3 = new Comment();
        video2Comment3._commenter = "Sarah Cook";
        video2Comment3._text = "That was suspiciously easy.";

        Video video3 = new Video();
        video3._title = "Homemade Whipped Cream in Kitchen-Aid Standmixer";
        video3._author = "AllThingsSweet";
        video3._length = 354;
        video3.NumComments();

        Comment video3Comment1 = new Comment();
        video3Comment1._commenter = "HomemadeIsBest";
        video3Comment1._text = "Love my Kitche-Aid! Will be making this!";

        Comment video3Comment2 = new Comment();
        video3Comment2._commenter = "Jud Kramer";
        video3Comment2._text = "What's wrong with a hand mixer? Seems like a lot of fuss to me.";

        Comment video3Comment3 = new Comment();
        video3Comment3._commenter = "WhipItGood";
        video3Comment3._text = "Are there sales for these things? It looks expensive, but awesome!";

        Video video4 = new Video();
        video4._title = "Kitchen-Aid Review - The Good, The Bad, and The Delicious ";
        video4._author = "Kevin Reviewer";
        video4._length = 423;
        video4.NumComments();

        Comment video4Comment1 = new Comment();
        video4Comment1._commenter = "MustBuyThings";
        video4Comment1._text = "Take my money.";

        Comment video4Comment2 = new Comment();
        video4Comment2._commenter = "Debbie Frugal";
        video4Comment2._text = "Doesn't seem worth the money.";

        Comment video4Comment3 = new Comment();
        video4Comment3._commenter = "Captain Inquisitive";
        video4Comment3._text = "About how long do these last?";

        video1._comments.Add(video1Comment1);
        video1._comments.Add(video1comment2);
        video1._comments.Add(video1comment3);

        video2._comments.Add(video2Comment1);
        video2._comments.Add(video2Comment2);
        video2._comments.Add(video2Comment3);

        video3._comments.Add(video3Comment1);
        video3._comments.Add(video3Comment2);
        video3._comments.Add(video3Comment3);

        video4._comments.Add(video4Comment1);
        video4._comments.Add(video4Comment2);
        video4._comments.Add(video4Comment3);

        List<Video> videos = new List<Video>()
        {
            video1,
            video2,
            video3,
            video4
        };

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }

    }
}