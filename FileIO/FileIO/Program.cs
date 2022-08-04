using System;
using System.IO;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*      READING FILE

            string text = System.IO.File.ReadAllText(@"C:\Users\emir7\Desktop\C#\AAFiles\test.txt");

            Console.WriteLine("test.txt contains is {0}", text);
            */

            // WRITE FILE

            //method 1

            string[] lines = { "Emirhan 2042", "Berat 1024", "Ensar 0" };

            File.WriteAllLines(@"C:\Users\emir7\Desktop\C#\AAFiles\highscores.txt", lines);

            //method 2

            using (StreamWriter file = new StreamWriter(@"C:\Users\emir7\Desktop\C#\AAFiles\highscoreWithoutEnsar.txt"))
            {

                foreach (string line in lines)
                {
                    if (!line.Contains("Ensar"))
                    {

                        file.WriteLine(line);

                    }

                }

            }
        }
    }
}
