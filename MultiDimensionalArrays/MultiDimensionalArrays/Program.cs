using System;

namespace MultiDimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[,] {

            {1,2,3 },
            {4,5,6 },
            {7,8,9 }

            };

            for (int i = 0, j = 2; i < array2D.GetLength(0); i++, j--)
            {
                if ( j == 2){
                    Console.Write("  ");
                }else if (i == 1) {
                    Console.Write(" ");
                }
                Console.WriteLine(array2D[i, j]);

            }

            string[,,] array3Dstring = new string[,,] {

                { {"Wesley", "Sneijder" }, {"Didier" , "Drogba" }, {"Fernando", "Muslera" }, {"Felipe", "Melo" } },
                { { "Cristiano", "Ronaldo"}, {"Lionel", "Messi" }, { "Ngolo", "Kante" }, {"Karim","Benzema" } },
                { { "Scottie" , "Pippen"}, {"Dennis", "Rodman" }, { "Micheal", "Jordan"}, {"Phil", "Jackson" } },
                { { "Paulo", "Coelho" }, {"George" , "Orwell" }, { "Sigmund", "Freud" }, { "Dogan", "Cuceloglu" } },



            };
            Console.WriteLine("Those printing from nested for loop");

                for (int i = 0; i < array3Dstring.GetLength(0); i++)
                {
                    for (int j = 0; j < array3Dstring.GetLength(1); j++)
                    {
                        for (int k = 0; k < array3Dstring.GetLength(2); k++)
                        {

                            Console.Write(array3Dstring[i, j, k]);

                            if (k == 1) {
                                Console.WriteLine(" ");
                            }
                        }
                    }
                }

            Console.WriteLine("\nThose printing from foreach loop");

            foreach (string str in array3Dstring) { 
            
                Console.WriteLine (str);    
            
            }

            

        }


    }
}
