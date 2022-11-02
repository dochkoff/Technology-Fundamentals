using System;
using System.Linq;
using System.Collections.Generic;

namespace P04_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentInfo = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firsName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);

                Student student = new Student(firsName, lastName, grade);
                students.Add(student);
            }

            List<Student> orderedStudents = students.
                OrderByDescending(x => x.Grade)
                .ToList();

            foreach (Student student in orderedStudents)
            {
                Console.WriteLine(student);
            }

        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:F2}";
        }
    }
}
