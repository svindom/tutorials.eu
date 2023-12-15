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
            Hashtable table = new Hashtable();

            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 67);
            students[1] = new Student(2, "Ola", 32);
            students[2] = new Student(3, "Kris", 89);
            students[3] = new Student(1, "Sha sha", 12);
            students[4] = new Student(5, "Iu", 29);

            foreach (Student s in students)
            {
                if(!table.ContainsKey(s.Id))
                {
                    table.Add(s.Id, s);
                    Console.WriteLine($"Student with ID{s.Id} was added.");
                }
                else
                {
                    Console.WriteLine($"Sorry, a student with same ID already exists ID: {s.Id}");
                }
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