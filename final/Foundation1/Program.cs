using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video v1 = new Video();
        Comments c1 = new Comments();
        v1._videoTitle = "We Spent 5.5 Hours Underground";
        v1._author = "Chance Willstead";
        v1._length = "32:50";
        c1._name = "@creepybeat";
        c1._comment = "haha  i am the subscriber number 60 =)";
        c1.AddComments();
        c1._name = "@caliwilstead4616";
        c1._comment = "So sick!";
        c1.AddComments();
        c1._name = "@ashtondotson9177";
        c1._comment = "Wow very epic";
        c1.AddComments();
        v1.DisplayVidDetals();
        c1.DisplayCommentInfo();

        Video v2 = new Video();
        Comments c2 = new Comments();
        v2._videoTitle = "Free soloing the Grand Teton in White-shirts and Ties! How hard could it be?";
        v2._author = "Chance Willstead";
        v2._length = "33:24";
        c2._name = "@shareejenson6678";
        c2._comment = "Pie costume";
        c2.AddComments();
        c2._name = "@AlexWalters-xw8uq";
        c2._comment = "The shirts r whatever but pants on the grand is diabolical";
        c2.AddComments();
        c2._name = "@chancewilstead";
        c2._comment = "I'm pretty sure they're were literally dress pants";
        c2.AddComments();
        v2.DisplayVidDetals();
        c2.DisplayCommentInfo();

        Video v3 = new Video();
        Comments c3 = new Comments();
        v3._videoTitle = "I Shouldn't Have Driven in the Bus Destruction Derby";
        v3._author = "Prestongoes";
        v3._length = "25:54";
        c3._name = "@conorv11";
        c3._comment = "You can tell this video really pushed Preston out of his comfort zone. Much respect for getting through it! Love the video.";
        c3.AddComments();
        c3._name = "@Pineberrries";
        c3._comment = "This is how the busses were driven back in our parents days to make sure there were no snow days.";
        c3.AddComments();
        c3._name = "@midnight_luna1178";
        c3._comment = "3:45 shoes on the bed is unhinged";
        c3.AddComments();
        v3.DisplayVidDetals();
        c3.DisplayCommentInfo();

        Console.WriteLine("\n\n");
    }
}