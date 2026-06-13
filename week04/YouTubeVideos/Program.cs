using System;
//To be able to use Lists
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Creating a master list to hold all our video objects
        List<Video> videos = new List<Video>();

        //Video1
        Video v1 = new Video("Learn how to programming easy peasy", "Mauricio Ramirez", 400);
        // Instantiating Comment objects directly inside the method call
        v1.AddComment(new Comment("Louis", "Outstanding explanation!"));
        v1.AddComment(new Comment("Ben", "Finally understood this topic and was able to pass the exam!!!"));
        v1.AddComment(new Comment("Brittany", "Could you do a video about how to iterate through a list?"));
        videos.Add(v1); // Don't forget to push it to the list!

        //Video 2
        Video v2 = new Video("Smartphone Review: iPhone Pro 17", "Geek Expert", 500);
        v2.AddComment(new Comment("Sofia", "Love the picture resolution"));
        v2.AddComment(new Comment("Diego", "How long does the battery endures?"));
        v2.AddComment(new Comment("Amelia", "Waiting for the next unboxing!"));
        videos.Add(v2);

        //Video 3
        Video v3 = new Video("How to Study more effectively", "Benjamin Sanders", 350);
        v3.AddComment(new Comment("Charlotte", "So encouraging! Please visit my channel and give me feedback on my latest video."));
        v3.AddComment(new Comment("Evelyn", "I will apply these tips this afternoon ;)"));
        v3.AddComment(new Comment("Isabella", "Yesterday I applied this information and got an A in my quiz!"));
        videos.Add(v3);

        //Outer loop: Iterating through each video inside the collection
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            // Inner loop: Reaching inside the current video, fetching its comment list, 
            // and prints each comment.
            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine($"- {c.Name}: {c.Text}");
            }

            // Separator line to avoid look like a wall of text
            Console.WriteLine("______________________________________\n");

        } //Close the outer video foreach loop
    }
}