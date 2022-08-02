using System;

namespace LoopsLittleChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int keep = 0;
            string userInput;
            userInput = Console.ReadLine();
            while (keep == 0) {

                if (userInput.Equals(""))
                {

                    keep = 1;

                }
                userInput = Console.ReadLine();
            }
            Console.Read();
        }
    }
}
