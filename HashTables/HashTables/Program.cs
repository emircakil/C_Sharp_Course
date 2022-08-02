using System;
using System.Collections;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();

            Student emir = new Student(1, "Emirhan Cakil", 23);
            Student berat = new Student(2, "Berat Dal", 100);
            Student emre = new Student(3, "Emre Sari", 99.5);
            Student fatih = new Student(4, "Fatih Kartal", 0.2);

            studentTable.Add(emir.ID , emir);
            studentTable.Add(berat.ID, berat);
            studentTable.Add(emre.ID, emre);
            studentTable.Add(fatih.ID, fatih);

            foreach (Student student in studentTable.Values) {

                Console.WriteLine("{0} id, {1} name, {2} average ", student.ID, student.Name, student.Average);
            }

            foreach (DictionaryEntry entry in studentTable) {

                Student temporary = (Student)entry.Value;
                Console.WriteLine("{0} id, {1} name, {2} average ", temporary.ID, temporary.Name, temporary.Average);


            }


        }
    }


    class Student { 
    
        public int ID { get; set; }
        public string Name { get; set; }
        public double Average { get; set; }

        public Student(int ID, string Name, double Average) {

            this.ID = ID;
            this.Name = Name;
            this.Average = Average;
        
        }
    
    }
}
