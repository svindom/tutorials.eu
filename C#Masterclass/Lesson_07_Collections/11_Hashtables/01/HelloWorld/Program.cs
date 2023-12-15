using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {   // Key - Value
        // Auto - Car

        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // retrive individual item with known ID
            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            Console.WriteLine($"Student ID: {storedStudent1.Id}, Name: {storedStudent1.Name}, GPA {storedStudent1.GPA}");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            // retrive all values from a Hahstable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"Student ID: {temp.Id}");
                Console.WriteLine($"Student Name: {temp.Name}");
                Console.WriteLine($"Student GPA: {temp.GPA}");
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine($"Student ID: {value.Id}");
                Console.WriteLine($"Student Name: {value.Name}");
                Console.WriteLine($"Student GPA: {value.GPA}");
                Console.WriteLine();
            }
        }
    }

    class Student
    {
        //property called Id
        public int Id { get; set; }
        //property called GPA
        public string Name { get; set; }
        //simple constructor
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;   
            this. GPA = GPA;
        }
    }
}