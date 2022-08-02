using System;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Emirhan");
            arrayList.Add(9);
            arrayList.Add("Drogba");
            arrayList.Add(11);
            arrayList.Add("problem");

            arrayList.Remove("problem");

            int sum = 0;
            // or

            // arrayList.RemoveAt(4);


            foreach (object obj in arrayList) { 
            
                Console.WriteLine(obj);

                if (obj is int) {

                    sum += (int)obj;                }

            }
            Console.WriteLine("Sum of integers: " + sum);
            
        }
    }
}
