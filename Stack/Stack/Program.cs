using System;
using System.Collections.Generic;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            foreach (int i in intArray) {

                Console.Write(i + " ");
                stack.Push(i);
            }
            Console.WriteLine( " ");
            while (stack.Count > 0)
            {

                int number = stack.Pop();
                Console.Write(number + " ");

            }

        }
    }
}
