using System;
using System.Linq;
using System.Collections.Generic;

namespace P04_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] studentInfo = input.Split();

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string city = studentInfo[3];

                Student student = new Student(firstName, lastName, age, city);

                students.Add(student);

                input = Console.ReadLine();
            }

            string desiredCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.City == desiredCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}