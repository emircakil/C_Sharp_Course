using System;

namespace DecisionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tempretureString = Console.ReadLine();
            int tempreture;
            int number;

            if (int.TryParse(tempretureString, out number))
            {

                tempreture = number;
            }
            else {

                tempreture = 0;
                Console.WriteLine("Value entered, was no number. 0 set as tempreture.");
            }


            Console.WriteLine("Tempreture: " + tempreture);
            if (tempreture < 10)
            {

                Console.WriteLine("Take o coat");

            }
            else if (tempreture == 10) { 
            
                Console.WriteLine("It's 10 C degree" );
            }else
            {

                Console.WriteLine("Weather is so beatiful");
            }
            Console.Read();
            
        }
    }
}
