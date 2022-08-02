using System;

namespace MethodChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "berat";
            string friend2 = "emre";
            string friend3 = "yakup";

            meeting(friend1);
            meeting(friend2);
            meeting(friend3);
        }

        public static void meeting(string myFriend) {

            Console.WriteLine("Hi {0}, my friend!", myFriend);
        }
    }
}
