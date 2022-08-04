using System;
using System.Collections.Generic;

namespace IEnumerableExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> unknownList;

            unknownList = GetCollections(1);
            foreach (int i in unknownList) { 
            
                Console.WriteLine(i);
            }

            unknownList = GetCollections(2);
            foreach (int i in unknownList)
            {

                Console.WriteLine(i);
            }

            unknownList = GetCollections(100);
            foreach (int i in unknownList)
            {
                Console.WriteLine(i);

            }

        }

        static IEnumerable<int> GetCollections(int condition){

            List<int> list = new List<int> { 1,2,3,4,5};

            Queue<int> queue = new Queue<int>();
           
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);

            if (condition == 1)
            {

                return list;
            }
            else if (condition == 2) {

                return queue;
            }else
            {

                return new int[]{ 11,12,13,14,15};
            }

            
        }
    }
}
