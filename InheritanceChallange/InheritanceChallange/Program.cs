using System;

namespace InheritanceChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Boss boss1 = new Boss("Emirhan","Cakil", 12000, "Race Cars");

            Trainee trainee1 = new Trainee("Emo", "Cakil", 5000, 10, 5);

                boss1.Lead();

            trainee1.Work();


        }
    }
}
