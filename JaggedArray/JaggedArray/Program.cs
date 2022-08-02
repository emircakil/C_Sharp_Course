using System;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first way

            int[][] jaggedArray1 = new int[3][];

            jaggedArray1[0] = new int[3];
            jaggedArray1[1] = new int[7];

            jaggedArray1[0] = new int[] { 1,2,3};
            jaggedArray1[1] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            jaggedArray1[2] = new int[] { 10, 20, 30, 40 };
            

            Console.WriteLine(jaggedArray1[2][1]);

            int[][] jaggedArray2 = new int[][] {

            new int[] { 1,2,3,4,5},
            new int[] { 1,2,3},
            new int[] { 5,6,7,8}

            };

            for (int i = 0; i < jaggedArray2.GetLength(0); i++) {

                for (int j = 0; j < jaggedArray2[i].Length; j++) { 
                
                    Console.WriteLine(jaggedArray2[i][j]);
                
                }
            
            }

        }
    }
}
