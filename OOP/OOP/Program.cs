using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human emirhan = new Human("Emirhan Aydin" , "Cakil", "brown" , 20);
            /*
            emirhan.name = "Emirhan Aydin";  They are useless with constructor
            emirhan.lastName = "Cakil";
            */
            Human drogba = new Human("Didier" , "Drogba" , "black" , 44);

            /*
            drogba.name = "Didier";
            drogba.lastName = "Drogba";
            */

            Human ceza = new Human();

            Human sneijder = new Human("Wesley Benjamin", "Sneijder", "green");

            Human kratos = new Human("God", "Kratos");


            emirhan.IntroduceMyself();
            drogba.IntroduceMyself();
            ceza.IntroduceMyself();
            sneijder.IntroduceMyself();
            kratos.IntroduceMyself();
            Console.Read();
        }
    }
}
