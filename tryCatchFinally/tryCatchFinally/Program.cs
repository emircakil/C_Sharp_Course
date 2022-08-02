using System;

namespace tryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string num1String = Console.ReadLine();
            

            try
            {
                
                int number = int.Parse(num1String);
                Console.WriteLine(number);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }
            finally
            {

                Console.WriteLine("try/catch operators used");
                Console.Read();
            }

        }
    }
}
