using System;
using System.Collections.Generic;

namespace List_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person{ FirstName = "David", LastName = "Simpson", Age=50},
                new Person{ FirstName = "Merge", LastName = "Simpson", Age = 45},
                new Person{ FirstName = "Lisa", LastName = "Simpson", Age = 19},
                new Person{ FirstName = "Jack", LastName = "Simpson", Age = 16}
            };
            Console.WriteLine("Items in list: {0}",people.Count);
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public override string ToString() =>
            $"Name: {FirstName} {LastName}, Age: {Age}";
    }
}
