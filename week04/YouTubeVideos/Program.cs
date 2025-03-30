using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();
        List<string> name = new List<string> {"Joe Mama", "Ella Vader", "Lou Natic", "Anita Bath", "Al Paca"};
        List<string> text = new List<string> {"Great!", "needs improvement", "my whole existance is a lie", "who gave you the right?", "I loved it!"};

        Video video1 = new Video("night funny", "studio C", 59.7);
        for (int i = 0; i < name.Count; i++)
        {
            Comment comment = new Comment(name[i], text[i]);
            video1.AddComment(comment);
        }
        videos.Add(video1);

         Video video2 = new Video("Best Handguns of 2025", "Classic Firearms", 180);
        for (int i = 0; i < name.Count; i++)
        {
            Comment comment = new Comment(name[i], text[i]);
            video2.AddComment(comment);
        }
        videos.Add(video2);

        Video video3 = new Video("Best Rifles of all time", "Classic Firearms", 210.7);
        for (int i = 0; i < name.Count; i++)
        {
            Comment comment = new Comment(name[i], text[i]);
            video3.AddComment(comment);
        }
        videos.Add(video3);

        for (int i = 0; i < videos.Count; i++)
        {
            videos[i].PrintVideoDetails();
            videos[i].PrintComments();
            Console.WriteLine();
        }
        
        
        


        
    }
}