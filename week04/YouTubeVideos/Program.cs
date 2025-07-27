using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1 = new Video("Imagine Dragons", "Eyes Closed", "4:08");
        Video video2 = new Video("OneRepublic", "Nobody", "2:33");
        Video video3 = new Video("Bakermat", "Baianá", "3:20");

        Comments comment1_1 = new Comments("@Axon_smn", "NEW ERA OF IMAGINE DRAGONS IS COMING!!");
        Comments comment1_2 = new Comments("@MusicFan", "This song is amazing!");
        Comments comment1_3 = new Comments("@IDFan", "Can't stop listening to this track.");

        Comments comment2_1 = new Comments("@mangonow6350", "One Republic x Anime is something I never imagined, glad to be here 🫡");
        Comments comment2_2 = new Comments("@itadoriyuji9364", "YUNGBLUD intro and ONEREPUBLIC outro for Kaiju No.8, what a nice time to be alive");
        Comments comment2_3 = new Comments("@lynseharc", "I like the way they make the word “got you” sound like “kaiju”. Very brilliant.");

        Comments comment3_1 = new Comments("@ChillYourMind", "Such a good vibe song");
        Comments comment3_2 = new Comments("@@VITTORIAREINA", "summer vibes of this song are jusr soooooooooo high");
        Comments comment3_3 = new Comments("@@migelos1188", "Not a Brazilian. First time hearing this  song and got immediately hooked. brazillians have such a divine music");

        video1.AddComments(comment1_1);
        video1.AddComments(comment1_2);
        video1.AddComments(comment1_3);

        video2.AddComments(comment2_1); 
        video2.AddComments(comment2_2);
        video2.AddComments(comment2_3);

        video3.AddComments(comment3_1);
        video3.AddComments(comment3_2);
        video3.AddComments(comment3_3);

        video1.ShowDisplay();
        video2.ShowDisplay();
        video3.ShowDisplay();
    }
}
