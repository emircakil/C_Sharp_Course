using System;

namespace LoopsBreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                if (i == 3) {

                    Console.WriteLine("This loop has stopped on {0}", i);
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++) {

                if (i == 3) {

                    Console.WriteLine("This loop skipped at {0}", i);
                    continue;
                }

                Console.WriteLine(i);
            }
            Console.Read();

        }
    }
}
