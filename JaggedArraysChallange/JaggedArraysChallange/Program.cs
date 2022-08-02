using System;

namespace JaggedArraysChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] friends = new string[3][];

            friends[0] = new string[] { "Cinar", "Gul" };
            friends[1] = new string[] { "Kemal", "Mukaddes" };
            friends[2] = new string[] { "Zehra", "Harun" };

            for (int i = 0; i < friends.Length; i++) {

                Console.WriteLine("Family of number {0}", i);

                for (int j = 0; j < friends[i].Length; j++) {

                    Console.WriteLine("{0}", friends[i][j]);
                }
            
            }

        }
    }
}
