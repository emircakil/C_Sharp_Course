using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Box
    {
        private int length;
        private int height;
        
        public int Width { get; set; } // you can use this prop then double tap.

        public int FrontSurface
        {
            get {

                return length * height;
            }
        
        }

        public void setLength( int value) {

            this.length = value;
        
        }

        public int getLength() {

            return this.length;
        }

        public void setHeight(int value) {

            this.height = value;
        }

        public int getHeight() {

            return this.height;
        }

        public int Volume
        {
            get {

                return this.length * this.height  * this.Width;
            
            }
        
        }

        public void DisplayInfo() {

            Console.WriteLine("Length is {0}, Height is {1}, Width is {2}, Volume is {3}", length, height, Width, Volume);
        }
    }

   
}
