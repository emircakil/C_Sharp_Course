using System;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\emir7\Desktop\C#\AAFiles\test.txt");

            Console.WriteLine("Test.txt is contains {0}", text);

        }
    }
}
