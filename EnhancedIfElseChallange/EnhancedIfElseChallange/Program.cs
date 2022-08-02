using System;

namespace EnhancedIfElseChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tempretureString = Console.ReadLine();
            int tempreture;

            if (Int32.TryParse(tempretureString, out tempreture))
            {

                checkTempreture(tempreture);
            }
            else
            {

                Console.WriteLine("Not a valid tempreture.");
                Console.Read();
            }
        }

        public static void checkTempreture(int tempreture) {

            string tempResult = tempreture <= 15 ? "It's too cold here" :
                (tempreture >= 16 && tempreture <= 28) ? "It is ok" :
                 "Its so hot here";

            Console.WriteLine(tempResult);

            Console.Read();
        }

    }
}
