using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedSetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var set = new SortedSet<Student>();

            var student1 = new Student("Anna", 40);
            var student2 = new Student("Anna", 16);
            var student3 = new Student("Anna", 32);

            set.TakeWhile(x => x.name == ":")
            set.Add(student1);
            set.Add(student2);
            set.Add(student3);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Student : IComparable<Student>
    {
        public string name;
        private int age;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Student? other)
        {
            int res = this.name.CompareTo(other.name);

            if (res == 0)
            {
                res = this.age.CompareTo(other.age);
            }
            return res;
        }

        public override string ToString()
        {
            return $"Student: {name}, age {age}";
        }
    }
}
