using System;
using System.Collections.Generic; 

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- YouTube Video and Comment Tracker ---");
        Console.WriteLine();

        List<Video> videosList = new List<Video>();

        Video video1 = new Video("C# For Beginners - Full Course", "Sebastian Ethington", 7200);
        video1.AddComment("PatrickStar", "Great tutorial! I feel like this video was great.");
        video1.AddComment("BobTheBuilder", "Helped me a lot with my first C# project.");
        video1.AddComment("CharlieCode", "Could you do a video on advanced topics next?");
        videosList.Add(video1);

        Video video2 = new Video("Baking the Perfect Cookies", "KitchenKing", 1800);
        video2.AddComment("DaveDough", "My cookies are finally tasty! Thanks!");
        video2.AddComment("EveEats", "Love your recipes. This one is a keeper.");
        video2.AddComment("FrankFoodie", "What kind of flour do you recommend?");
        video2.AddComment("GraceGourmet", "The gooey middle was amazing!");
        videosList.Add(video2);

        Video video3 = new Video("Exploring Ancient Ruins - Part 1", "AdventureSeeker", 3600);
        video3.AddComment("HenryHistory", "Incredible footage!");
        video3.AddComment("IvyExplorer", "Can't wait for Part 2!");
        video3.AddComment("JackJourney", "Makes me want to travel there.");
        videosList.Add(video3);
        
        Video video4 = new Video("Learning to Play Guitar: Basic Chords", "MusicMaestro", 2400);
        video4.AddComment("KathyStrings", "Finally understand barre chords!");
        video4.AddComment("GuitarGary", "Your teaching style is awesome.");
        video4.AddComment("MiaMelody", "What guitar are you using in the video?");
        videosList.Add(video4);


        Console.WriteLine("--- Displaying All Video Details ---");
        Console.WriteLine();

        foreach (Video currentVideo in videosList)
        {
            currentVideo.DisplayVideoDetails();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
        }

        Console.WriteLine("Program finished. Press any key to exit.");
        Console.ReadKey();
    }
}