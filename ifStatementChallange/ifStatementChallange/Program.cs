using System;

namespace ifStatementChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to register (type r) or login in (type l) ");
            string rORl = Console.ReadLine();

            if (rORl.Equals("r"))
            {
                Registration();
            }
            else if (rORl.Equals("l")) {
            
                logIn();
            }

             else {

                Console.WriteLine("Please type, r or l");
            }
            
        }

        public static void Registration()
        {

            Console.WriteLine("Please create username and password. ex. (username/password");
            string username = Console.ReadLine();
            Console.WriteLine("Congrulation! User {0} has been registered.", username);
            Console.Read();

        }

        public static void logIn() {

            Console.WriteLine("Please enter your username.");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();

            if (userName.Equals("emirhan") && password.Equals("sifre123"))
            {

                Console.WriteLine("Loging in succesful");
            }
            else
            {

                Console.WriteLine("Please be sure for username or password");
            }
            Console.Read();
        }
    }
}
