using System;
using System.Collections.Generic;

namespace IEnumerableExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1,2,3,4,5};
            int[] array = { 6, 7, 8, 9, 10 };

            SumCollections(list);
            SumCollections(array);

        }

        public static void SumCollections(IEnumerable<int> collection) {

            int sum = 0;

            foreach (int i in collection)
            {
                sum += i;

            }

            Console.WriteLine(sum );
        }
    }
}
