using System;
using System.Collections;

namespace HashtableChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();

            Student emo = new Student(1, "Emirhan", 78.5);
            Student berat = new Student(2, "Berat", 100);

            studentTable.Add(emo.ID, emo);
            studentTable.Add(berat.ID, berat);

            Console.WriteLine("Please enter new student name");

            string name = Console.ReadLine();

            Console.WriteLine("Please, enter student ID" );

            string IDstring = Console.ReadLine();


            int id = int.Parse(IDstring);


            if (ConstainsKeys(studentTable, id))
            {

                Console.WriteLine("Please, enter the GPA.");
            }
            else {

                Console.WriteLine("Sorry, A student with the same ID already exists.");
            }

            string GPAstring = Console.ReadLine();

            double gpa = double.Parse(GPAstring);

            Console.WriteLine("New student creating succesfully!");


            Student newStudent = new Student(id, name, gpa);

            studentTable.Add(newStudent.ID, newStudent);

            Console.WriteLine("All students: ");

            foreach (DictionaryEntry entry in studentTable) { 
            
                Student student = (Student)entry.Value;

                Console.WriteLine("Name is: {0}, ID is: {1}, GPA is: {2}", student.Name, student.ID, student.GPA);
            
            }

        }

        public static bool ConstainsKeys(Hashtable studentsTable, int id)
        {

            foreach (DictionaryEntry entry in studentsTable)
            {

                Student student = (Student)entry.Value;

                if (student.ID == id) {

                    return false;
                }

            }

            return true;
        }
    }

    
    class Student {

        public int ID { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }

        public Student(int iD, string name, double gPA)        {
            ID = iD;
            Name = name;
            GPA = gPA;

       } 
    }
}
