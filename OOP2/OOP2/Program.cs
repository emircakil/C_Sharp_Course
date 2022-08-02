using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.setLength(3);
            box.setHeight(4);
            box.Width = 5;

            Console.WriteLine("Front Surface is " + box.FrontSurface);
            box.DisplayInfo();


        }
    }
}
