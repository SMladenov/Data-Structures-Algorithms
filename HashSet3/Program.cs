using System;
using System.Collections.Generic;

namespace HashSet3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Gosho");
            Person p2 = new Person("Misho");
            Person p3 = new Person("Gosho");
            Person p4 = new Person("Tisho");

            HashSet<Person> set = new HashSet<Person>();

            set.Add(p1);
            set.Add(p2);
            set.Add(p3);
            set.Add(p4);

            Console.WriteLine(set.Count);

            //Output: 4 ----- becase there is no override neither for Equals, neither for GetHashCode
        }
    }

    public class Person
    {
        string name;

        public Person(string name)
        {
            this.name = name;
        }

    }
}
