using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Third_Task
{
    internal class Program
    {
        static Dictionary<string, int> dic = new Dictionary<string, int>();
        
        static void Main(string[] args)
        {

            string command = string.Empty;

            List<string> names = new List<string>(1000000);

            while (command != "End")
            {
                string[] arguments = Console.ReadLine().Split(' ').ToArray();
                command = arguments[0];

                if (arguments[0] == "Append")
                {
                    string name = arguments[1];
                    AppendName(name, names);
                    Console.WriteLine("OK");
                }
                if (arguments[0] == "Insert")
                {
                    string name = arguments[2];
                    if (arguments[1] == "N")
                    {
                        names.Add(name);
                        Console.WriteLine("OK");
                    }
                    else if (int.TryParse(arguments[1], out int position))
                    {
                        if (position <= names.Count)
                        {
                            InsertAtPosition(position, name, names);
                            Console.WriteLine("OK");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                if (arguments[0] == "Find")
                {
                    string name = arguments[1];

                    Console.WriteLine(FindPeople(name));
                }
                if (arguments[0] == "Examine")
                {
                    int count = int.Parse(arguments[1]);

                    Console.WriteLine(Examine(count, names));
                }

            }
        }

        public static void AppendName(string name, List<string> names)
        {
            names.Add(name);
            DicAdd(name);
        }
        public static void InsertAtPosition(int position, string name, List<string> names)
        {
            if (position == 0)
            {
                names.Insert(0, name);
            }
            else
            {
                names.Insert(position, name);
            }
            DicAdd(name);
        }
        public static int FindPeople(string name)
        {
           
            if (dic.ContainsKey(name))
            {
                return dic[name];
            }
            else
            {
                return 0;
            }
        }

        public static string Examine(int count, List<string> names)
        {
            StringBuilder sb = new StringBuilder();

            if (count > names.Count)
            {
                sb.AppendLine("Error");
                //Console.WriteLine("Error");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    sb.Append($"{names[i]} ");
                    //Console.Write($"{names[i]} ");
                    if (dic.ContainsKey(names[i]))
                    {
                        int value = dic[names[i]];
                        dic[names[i]] = value - 1;
                    }
                }
                sb.AppendLine();
                //Console.WriteLine();
                names.RemoveRange(0, count);
            }
            return sb.ToString();
        }

        public static void DicAdd(string name)
        {
            if (!dic.ContainsKey(name))
            {
                dic.Add(name, 1);
            }
            else
            {
                int value = dic[name];
                dic[name] = value + 1;
            }
        }
    }
}
