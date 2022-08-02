using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine(" ");
            int counter = 0;
            foreach (int k in nums) {

                Console.WriteLine(nums[counter]);
                counter++;
            }
            Console.WriteLine(" ");
            string[] friends = new string[5];
            friends[0] = "Berat Dal";
            friends[1] = "Yakup Bulbul";
            friends[2] = "Emre Sari";
            friends[3] = "Fatih Kartal";
            friends[4] = "Mehmet Parlak";

            foreach (string name in friends) {

                Console.WriteLine(name);
            }
        }
    }
}
