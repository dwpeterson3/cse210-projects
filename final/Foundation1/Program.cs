using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>(); 
        Video video1 = new Video("Johnny Lingo", "Patricia McGerr", 1440); 
        Video video2 = new Video("The Testaments: Of One Fold and One Shepherd", "Kieth Merrill", 3900); 
        Video video3 = new Video("The Cokeville Miracle", "T.C. Christensen", 5640); 

        video1.SaveComment(new Comment("TSHunter", "This movie was made and distributed by the Mormon Church. But, unlike most films that fall into the above category, this movie is not about religion, missionary work, joining any church, etc. and so forth. This short film could have quite possibly been made by anyone. That is what makes it so good."));
        video1.SaveComment(new Comment("jepowell", "Beyond the tremendous and true romantic love Johnny Lingo proves for his dear Mahana, he gives a tremendous object lesson in how to properly treat others, and bring out the very best in them."));
        video1.SaveComment(new Comment("dafalias", "Of course the story of Johnny Lingo is one of the classics for Mormon children; the message it conveys is true and probably much more important today than it was at the time it was made."));

        video2.SaveComment(new Comment("pererau", "I had heard a lot of things said about the movie before I saw it nearly two years after it opened, and so was wary of whether or not it would live up to its billing. The first 45 minutes of this hour-or-so long film are good, but nothing amazing. Then the action scene and then the scene where Christ comes takes you on an emotional roller-coaster and gets you thinking of what it would be like to be in that situation. It is very touching."));
        video2.SaveComment(new Comment("caesarmoridon", "This is a moving and touching film, but strays majorly from the text it represents. Many of the characters are fictional and the events embellished. With that said, the movie is well acted other than some over acting by the father and villain and sappy acting from many characters."));
        video2.SaveComment(new Comment("sidunrau", "The Testaments: Of One Fold and One Shepherd is moving and beautiful. It is obviously designed to focus the viewer on Mormonism's focus on the Savior. Nevertheless, most of the acting is well done, the scenery is beautiful, and the story line is interesting.")); 
        
        video3.SaveComment(new Comment("abelhawk", "I honestly can't help but laugh at these negative reviews about this movie. If you don't like the acting, effects, etc., fine, but giving the movie 1 star because you don't like the way the miracles in the movie were shown is stupid. The accounts of angels and miracles are documented by real people who went through this terrible situation. Whether they're true or not is besides the point."));
        video3.SaveComment(new Comment("welhof1", "Like others I had never heard of this incident and after reading about it, the movie does follow the events pretty close."));
        video3.SaveComment(new Comment("superscrounger", "This is a film about faith. I imagine many people who watch it may be aware of that beforehand. But if you weren't, and it projects ideals you disagree with, it is best to acknowledge that in a civil, thoughtful, non-attacking way."));
        video3.SaveComment(new Comment("k_gazo", "Once the movie got going, we both realized the script was terrible. The acting really wasn't as bad as I originally thought. There is only so much an actor can do with bad lines and a choppy narrative. I would have enjoyed learning more about the protagonist's background and motivation. We quickly saw that the movie was faith-based, but the lines questioning God seemed forced into the script and out of place. I really can't fault the actors, and as the movie progressed we did see more emotion evoked.")); 
        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();

        }

    }
}