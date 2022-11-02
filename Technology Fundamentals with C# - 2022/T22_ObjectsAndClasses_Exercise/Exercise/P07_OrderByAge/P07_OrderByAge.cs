using System;
using System.Linq;
using System.Collections.Generic;

namespace P07_OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var persons = new List<Person>();

            while (input != "End")
            {
                string[] personInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = personInfo[0];
                string personID = personInfo[1];
                int age = int.Parse(personInfo[2]);

                Person person = new Person(name, personID, age);
                persons.Add(person);

                input = Console.ReadLine();
            }

            var orderedByAge = persons.OrderBy(x => x.Age);

            foreach (var person in orderedByAge)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public Person(string name, string personID, int age)
        {
            Name = name;
            PersonID = personID;
            Age = age;
        }

        public string Name { get; set; }
        public string PersonID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.PersonID} is {Age} years old.";
        }
    }
}
