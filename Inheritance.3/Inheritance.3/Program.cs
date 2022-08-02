using System;

namespace Inheritance._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("My first job", "Emirhan_Cakil" , true);

            Console.WriteLine(post1.ToString());

            ImagePost imagepost1 = new ImagePost("My dog", "Emirhan_Cakil", true, "https://images/dog");
            Console.WriteLine(imagepost1.ToString());

            VideoPost videoPost = new VideoPost("My new home's video", "Emirhan_Cakil", true, "https://videos/home", 1000);
            Console.WriteLine(videoPost.ToString());
            videoPost.Play();
            Console.WriteLine("Press any key at stop the video");
            Console.ReadKey();
            videoPost.Stop();

         }
    }
}

