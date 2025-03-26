using System;
using modul6_103022300123;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Praktikan");

        List<SayaTubeVideo> videos = new List<SayaTubeVideo>
            {
                new SayaTubeVideo("Review Film Interstellar oleh Praktikan"),
                new SayaTubeVideo("Review Film Inception oleh Praktikan"),
                new SayaTubeVideo("Review Film The Dark Knight oleh Praktikan"),
                new SayaTubeVideo("Review Film Parasite oleh Praktikan"),
                new SayaTubeVideo("Review Film The Godfather oleh Praktikan"),
                new SayaTubeVideo("Review Film Pulp Fiction oleh Praktikan"),
                new SayaTubeVideo("Review Film Fight Club oleh Praktikan"),
                new SayaTubeVideo("Review Film Forrest Gump oleh Praktikan"),
                new SayaTubeVideo("Review Film The Matrix oleh Praktikan"),
                new SayaTubeVideo("Review Film The Shawshank Redemption oleh Praktikan")
            };

        foreach (var video in videos)
        {
            user.AddVideo(video);
            video.IncreasePlayCount(100);
        }

        user.PrintAllVideoPlaycount();

        Console.WriteLine("Total play count dari semua video: " + user.GetTotalVideoPlayCount());
        Console.ReadLine();
    }
}
