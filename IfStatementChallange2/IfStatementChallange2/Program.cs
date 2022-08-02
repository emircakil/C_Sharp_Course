using System;

namespace IfStatementChallange2
{
    internal class Program
    {
        static int score = 55;
        static string player = "emo";

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your score");
            string keepScoreString = Console.ReadLine();
            int keepScore = int.Parse(keepScoreString);

            Console.WriteLine("Please enter your name");
            string keepName = Console.ReadLine();

            highscorePlayer(keepScore, keepName);
            Console.Read();
        }

        public static void highscorePlayer(int highscore, string highscorePlayer) {

            if (highscore > score)
            {

                Console.WriteLine("New highscore is {0}", highscore);
                Console.WriteLine("New highscore holder is {0}", highscorePlayer);

            }
            else {

                Console.WriteLine("The old highscore of {0}, couldn't be broken and is still held by {1}.", score, player);
            }

        
        }
    }
}
