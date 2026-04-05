using System;
using Foundation1;

class Program
{
    static void Main(string[] args)
    {
        //Make videos
        List<Video> videos = new List<Video>();
        videos.Add(new Video("All The Ghosts You Will Be","VSauce",1320));
        videos.Add(new Video("The Answer is Not a Hut in The Woods","exurb2a",2786));
        videos.Add(new Video("I left YouTube two years ago. Time to come back.","Tom Scott",101));

        //add comments
        videos[0].AddComment("RegularJoe","Greatest ad read of all time.");
        videos[0].AddComment("SomebodyF4rted","Micheal you are my idol!!1!");
        videos[0].AddComment("GoGoogyGo","deep");

        videos[1].AddComment("ilikebritishpeople","i listened to this 35 times 2day");
        videos[1].AddComment("troubled_youth","Hmm I think maybe I will go walk the Appalachian trail...");
        videos[1].AddComment("wannabe2136","OMG the part about copying whoever you just read #relateable");

        videos[2].AddComment("Man Carrying Thing","Welcome back!");
        videos[2].AddComment("Jester R Tolkien","RETURN OF THE KING");
        videos[2].AddComment("kronixONLINE","YOOO Man Carrying Thing commented!!!");

        //print videos
        Console.WriteLine("YouTube");
        foreach(Video video in videos)
        {
            Console.WriteLine();
            video.Display();
        }
    }
}