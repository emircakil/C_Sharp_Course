using System;

namespace Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float myFloat = float.Parse(stringForFloat);
            int myInt = Int32.Parse(stringForInt);

            Console.WriteLine((float)myInt + myFloat);

        }
    }
}
