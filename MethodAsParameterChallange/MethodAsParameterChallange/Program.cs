using System;

namespace MethodAsParameterChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] { 10, 20, 30, 40, 50 };

            number = happines(number);

            foreach (int value in number) { 
            
                Console.WriteLine(value);
            }

        }

        public static int[] happines(int[] list) {

            for (int i = 0; i < list.Length; i++)
            {
                list[i] += 2;
            
            }

            return list;
        
        }

    }
}
