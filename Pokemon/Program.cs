using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            var list = new List<Pokemon>(100000);

            var dic = new Dictionary<string, List<Pokemon>>();

            while (command != "end")
            {
                string input = Console.ReadLine();
                var parameters = input.Split(' ').ToArray();
                command = parameters[0];

                if (command == "add")
                {
                    string name = parameters[1];
                    string type = parameters[2];
                    int power = int.Parse(parameters[3]);
                    int index = int.Parse(parameters[4]) - 1;


                    if (dic.TryGetValue(type, out var tempList))
                    {
                        tempList.Add(new Pokemon(name, power, type));
                    }
                    else
                    {
                        dic.Add(type, new List<Pokemon>()
                        { new Pokemon(name, power, type)} );
                    }

                    list.Insert(index, new Pokemon(name, power, type));
                    Console.WriteLine($"Added pokemon {name} to position {index + 1}");
                    continue;
                }

                if (command == "find")
                {
                    string type = parameters[1];

                    var typeItems = new List<Pokemon>();
                    if (dic.TryGetValue(type, out var tempItems))
                    {
                        typeItems = tempItems;
                    }
                    else
                    {
                        Console.WriteLine($"Type {type}: ");
                        continue;
                    }

                    var items = typeItems
                        .OrderBy(i => i.Name)
                        .ThenByDescending(i => i.Power)
                        .Take(5)
                        .ToList();
                    
                    if (items.Count == 1)
                    {
                        Console.WriteLine($"Type {type}: {items[0].Name}({items[0].Power})");
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append($"Type {type}: ");
                        //Type Water: Squirtle(40); Squirtle(22)
                        for (int i = 0; i < items.Count - 1; i++)
                        {
                            sb.Append($"{items[i].Name}({items[i].Power}); ");
                        }
                        sb.Append($"{items[items.Count - 1].Name}({items[items.Count - 1].Power})");
                        Console.WriteLine(sb);
                    }
                    continue;
                }

                if (command == "ranklist")
                {
                    int startIndex = int.Parse(parameters[1]) - 1;
                    int endIndex = int.Parse(parameters[2]) - 1;

                    int counter = int.Parse(parameters[1]);

                    if (startIndex == endIndex)
                    {
                        Console.Write($"{counter}. {list[endIndex].Name}({list[endIndex].Power})");
                        Console.WriteLine();
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();

                        for (int i = startIndex; i < endIndex; i++)
                        {
                            sb.Append($"{counter}. {list[i].Name}({list[i].Power}); ");
                            counter++;
                        }
                        sb.Append($"{counter}. {list[endIndex].Name}({list[endIndex].Power})");
                        Console.WriteLine(sb);
                    }
                }
            }
        }

        public class Pokemon
        {
            public string Name;
            public int Power;
            public string Type;
            public Pokemon(string name, int power, string type)
            {
                this.Name = name;
                this.Power = power;
                this.Type = type;    

            }
        }
    }
}
