using System;

namespace Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myFirstString = "23";
            string mySecondString = "9";

            int myInt = Int32.Parse(myFirstString);
            int myInt2 = Int32.Parse(mySecondString);

            Console.WriteLine(myInt + myInt2);
        }
    }
}
