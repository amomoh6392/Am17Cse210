using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("Learn C# in 20 Minutes", "Code Academy", 1200);
        Video video2 = new Video("Top 10 Football Goals", "Sports TV", 900);
        Video video3 = new Video("How to Cook Jollof Rice", "Kitchen Master", 1500);
        Video video4 = new Video("Travel Guide to Germany", "Travel World", 1800);
        
        video1.AddComment(new Comment("John", "Great tutorial!"));
        video1.AddComment(new Comment("Sarah", "Very easy to understand."));
        video1.AddComment(new Comment("Michael", "This helped me a lot while i tried writing my code."));

        video2.AddComment(new Comment("David", "Amazing goals!"));
        video2.AddComment(new Comment("Chris", "Best compilation ever."));
        video2.AddComment(new Comment("Emma", "I enjoyed every moment."));

        video3.AddComment(new Comment("Grace", "The recipe looks delicious."));
        video3.AddComment(new Comment("Daniel", "I will try this today."));
        video3.AddComment(new Comment("Sophia", "Thanks for sharing! i was able to make it because you posted it."));

        video4.AddComment(new Comment("Abinadi", "Germany looks beautiful from the video."));
        video4.AddComment(new Comment("Sam", "Very informative video."));
        video4.AddComment(new Comment("Jpetter", "I want to visit Germany now."));

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("※※※※※※※※※※※※※※※※※");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine("※※※※※※※※※※※※※※※※※");
            Console.WriteLine();
        }
    }
}