using System;
using System.IO;

namespace FileIOParsingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\emir7\Desktop\C#\AAFiles\input.txt");

            for(int i =0; i< text.Length; i++) {

                if (text[i].Contains("split")) {

                    text[i] += "\n";
                }
            }

            File.WriteAllLines(@"C:\Users\emir7\Desktop\C#\AAFiles\output.txt", text);
            
        }
    }
}
