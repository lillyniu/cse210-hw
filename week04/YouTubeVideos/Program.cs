using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    
        Video video1 = new Video("How to Tie a Knot", "Bubbliockz", 1959);
        Video video2 = new Video("Love in the Island", "ThePros", 450);
        Video video3 = new Video("A Beautiful Rendition of I Need Thee Every Hour", "The Church of Jesus Christ of Latter-day Saints", 4);
        Video video4 = new Video("Kendrick Lamar's Apple Music Super Bowl Halftime Show", "NFL", 13);

        video1.AddComment(new Comment("Julie", "That looks way too easy."));
        video1.AddComment(new Comment("Steven", "What a waste of a video."));
        video1.AddComment(new Comment("Chrissy", "My second grader could have done a better job."));

        video2.AddComment(new Comment("Roberto", "Put me on the next flight."));
        video2.AddComment(new Comment("Semisi", "Those people should leave nature alone."));
        video2.AddComment(new Comment("Janice", "This looks like it was filmed in Fiji."));
        video2.AddComment(new Comment("Damuni", "Awkward moment when you want to be an islander..."));

        video3.AddComment(new Comment("Srilakni", "I always feel the spirit with these."));
        video3.AddComment(new Comment("James", "Love this hymn."));
        video3.AddComment(new Comment("Cynthia", "What a beautiful voice!"));
        video3.AddComment(new Comment("Mondragon", "Que poderoso!"));

        video4.AddComment(new Comment("Violeta", "Idk what was worse, the game or the halftime show."));
        video4.AddComment(new Comment("Anthony", "Trash."));
        video4.AddComment(new Comment("Kentucky", "I hope Drake is watchin."));

        List<Video> videos = new List<Video> {video1, video2, video3, video4};

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        
        }
   }
}