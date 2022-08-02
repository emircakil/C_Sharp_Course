using System;

namespace EnhancedIfElseStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempreture = 120;
            string stateOfMatter;
            /*
            if (tempreture < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";
            */


            stateOfMatter = tempreture < 0 ? "solid" : tempreture > 100 ? "gas" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.ReadKey();
        }



    }
}
