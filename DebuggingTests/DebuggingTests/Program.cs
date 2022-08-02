using System;

namespace DebuggingTests
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;

           sum = sums(sum);

            for (int i = 0; i < 10; i++)

                sum += i;

            

        }

        public static int sums(int i)
        {

            for (int j = 0; j < 10; j++)
            {

                i += j;
            }

            return i;
        }

    }
}

