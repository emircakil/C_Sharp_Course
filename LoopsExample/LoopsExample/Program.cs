using System;

namespace LoopsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the how much students on the class");
            string currentStudentString = Console.ReadLine();
            int currentStudents = int.Parse(currentStudentString);
            int i = 0 ;
            int sumOfNotes = 0 ;
            do {
                Console.WriteLine("Please enter the note of student");
                string keepAStudentNoteString = Console.ReadLine();
                int keepAStudentNote = int.Parse(keepAStudentNoteString);

                sumOfNotes += keepAStudentNote;
                i++;
            } while (i < currentStudents);

            Console.WriteLine("Average of class: " + (sumOfNotes / currentStudents));
            Console.Read();

        }
    }
}
