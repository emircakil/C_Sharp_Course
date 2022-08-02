using System;

namespace LoopsChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;int counter = 0;
            string numberString;
            int number;

            while (true) { 

                numberString = Console.ReadLine();
                if (int.TryParse(numberString, out number)) {

                    if (number == -1) {

                        break;
                        
                    }
                } else { 
                
                    Console.WriteLine("Please enter only number");    
                }
                if (checkNumber(number))
                {

                    sum += number;
                    counter++;

                }
                else {

                    Console.WriteLine("Please enter number value of between 0,20");
                }
                
            }

            Console.WriteLine("Average of class {0}", ((double)sum / (double)counter));
            Console.Read();
        }

        public static bool checkNumber(int number) {

            if (number <= 20 && number >= 0)
            {

                return true;
            }
            else {
                return false;
            }
        
        }
    }
}
