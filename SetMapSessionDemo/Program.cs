using System;
using System.Collections.Generic;

namespace SetMapSessionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Despite the List who has a 0(1) add Complexity, if needed to resize, the complexity becomes 0(n), or if needed to loop over the collection

            var set = new HashSet<int>();
            set.Add(1); // 0(1) - Constant Complexity
            set.Add(2); // 0(1)
            set.Add(3);
            set.Add(4);
            set.Remove(3); // 0(1) - Constant Complexity
            set.Contains(1); // 0(1)

            set.Add(1); // The condition for adding an element is bool, meaning if an element is present, it will not add it.
            set.Add(1);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            // 2 equal objects will give the same hashCode

            //Person p1 = new Person();
            //Person p2 = new Person();
            //p1 = p2;
            //Console.WriteLine(p1.GetHashCode());

            Person p1 = new Person("John", 23);
            Person p2 = new Person("John", 23);

            //Without override the equals method as well, we will get 2 different persons with same name
            //With overriding Equals and GetHashCode, we will get 1 person for 2 instances with same names
            //Look below in Person Class
            var settwo = new HashSet<Person>();
            settwo.Add(p1);
            settwo.Add(p2);
            Console.WriteLine(new string('-', 10));
            Console.WriteLine(settwo.Count);

        }
    }

    class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public override bool Equals(object obj)
        {
            //return obj is Person other && this.name == other.name;
            return obj is Person other && this.name == other.name && this.age == other.age;
        }

        public override int GetHashCode()
        {
            //return name.GetHashCode();
            return HashCode.Combine(name, age);
        }
    }
}
