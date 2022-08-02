using System;
using System.Collections.Generic;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            while (queue.Count > 0) { 
            
              Console.WriteLine ( "Front of the {0}, deleting from queue",queue.Dequeue());
            }


        }
    }
}
