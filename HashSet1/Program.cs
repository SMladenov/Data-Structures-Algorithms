using System;
using System.Collections.Generic;

namespace HashSet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Person> people = new HashSet<Person>();

            people.Add(new Person("Alice"));
            people.Add(new Person("Bob"));
            people.Add(new Person("Alice"));
            people.Add(new Person("Bob"));

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            //Output: Alice, Bob, Alice, Bob
            
        }
    }

    public class Person
    {
        string name;

        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
