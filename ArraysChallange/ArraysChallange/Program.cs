using System;

namespace ArraysChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the value");
            string str = Console.ReadLine();

            Console.WriteLine("Please select datatype \n Press 1 for String \n Press 2 for Integer \n Press 3 for Boolean");

            string selectionString = Console.ReadLine();
            int selection = int.Parse(selectionString);
            int number;
            bool condition;

            switch (selection) {

                case 1:
                    if (IsAllAlphabetic(str))
                        Console.WriteLine("It's valid for String.");
                    else
                        Console.WriteLine("It's not valid for String");
                        break;
                case 2: if (int.TryParse(str, out number)) {
                        Console.WriteLine("It's valid for Integer.");
                    } else { 
                        Console.WriteLine("It's not valid for Integer.");
                    } break;

                case 3: if (str.Equals("true") || str.Equals("false"))
                    {

                        Console.WriteLine("It's valid for Boolean.");
                    }
                    else {
                        Console.WriteLine("It's not valid for Boolean.");
                    }break;
            }

            
            }
        static bool IsAllAlphabetic(string value)
        {

            foreach (char c in value)
            {

                if (!char.IsLetter(c))
                {

                    return false;
                }
            }
            return true;
        }
    }
}
