using System;

namespace ParamsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // you can sand to parameter like that with params keywords.

            integerArray(1, 2, 3, 4, 5);

            // params provide send to object as a parameter.
            objectArray(11, "Drogba", '#', 4.5);
            
             
        }

        public static void objectArray(params object[] list) {

            foreach (object i in list) {

                Console.Write(i + " ");
            
            }
        
        }

        public static void integerArray(params int[] list)
        {

            foreach (int i in list)
            {

                Console.Write(i + " ");

            }
        }
    }
}
