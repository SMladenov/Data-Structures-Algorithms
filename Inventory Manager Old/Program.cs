﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            var dic = new Dictionary<string, (double Price, string Type)>();

            var secondDictionary = new Dictionary<string, Dictionary<string, double>>();


            while (command != "end")
            {
                string input = Console.ReadLine();
                var parameters = input.Split(' ').ToArray();
                command = parameters[0];

                if (command == "add")
                {
                    string itemName = parameters[1];
                    double itemPrice = double.Parse(parameters[2]);
                    string itemType = parameters[3];

                    if (dic.TryAdd(itemName, (itemPrice, itemType)))
                    {
                        if (secondDictionary.TryAdd(itemType, new Dictionary<string, double>()
                        {
                            {itemName, itemPrice }
                        }))
                        {

                        }
                        else
                        {
                            secondDictionary[itemType].Add(itemName, itemPrice);
                        }


                        Console.WriteLine($"Ok: Item {itemName} added successfully");
                        //Ok: Item CowMilk added successfully
                    }
                    else
                    {
                        Console.WriteLine($"Error: Item {itemName} already exists");
                    }
                }

                if (command == "filter")
                {
                    if (parameters[2] == "type")
                    {
                        string type = parameters[3];

                        if (!secondDictionary.TryGetValue(type, out var temp))
                        {
                            Console.WriteLine($"Error: Type {type} does not exist");
                        }
                        else
                        {
                            var items2 = temp
                          .OrderBy(i => i.Value)
                          .ThenBy(i => i.Key)
                          .Take(10)
                          .ToList();

                            Console.Write("Ok: ");
                            for (int i = 0; i < items2.Count - 1; i++)
                            {
                                Console.Write($"{items2[i].Key}({items2[i].Value:f2}), ");
                            }
                            Console.Write($"{items2[items2.Count - 1].Key}({items2[items2.Count - 1].Value:f2})");
                            Console.WriteLine();
                        }


                        //var items = dic.Where(i => i.Value.Type.Equals(type))
                        //    .OrderBy(i => i.Value.Price)
                        //    .ThenBy(i => i.Key)
                        //    .Take(10)
                        //    .ToList();

                        //if (items.Count == 0)
                        //{
                        //    Console.WriteLine($"Error: Type {type} does not exist");
                        //}
                        //else
                        //{
                        //    Console.Write("Ok: ");
                        //    for (int i = 0; i < items.Count - 1; i++)
                        //    {
                        //        Console.Write($"{items[i].Key}({items[i].Value.Price:f2}), ");
                        //    }
                        //    Console.Write($"{items[items.Count - 1].Key}({items[items.Count - 1].Value.Price:f2})");
                        //    Console.WriteLine();
                        //}
                    }

                    if (parameters[2] == "price")
                    {
                        if (parameters[3] == "to")
                        {
                            double price = double.Parse(parameters[4]);

                            var items = dic.Where(i => i.Value.Price <= price)
                                .OrderBy(i => i.Value.Price)
                                .ThenBy(i => i.Key)
                                .ThenBy(i => i.Value.Type)
                                .Take(10)
                                .ToList();
                            if (items.Count == 0)
                            {
                                Console.WriteLine("Ok: ");
                            }
                            else
                            {
                                Console.Write("Ok: ");
                                for (int i = 0; i < items.Count - 1; i++)
                                {
                                    Console.Write($"{items[i].Key}({items[i].Value.Price:f2}), ");
                                }
                                Console.Write($"{items[items.Count - 1].Key}({items[items.Count - 1].Value.Price:f2})");
                                Console.WriteLine();
                            }
                        }

                        if (parameters[3] == "from")
                        {
                            int inputCount = input.Split(' ').Count();

                            if (inputCount == 5)
                            {
                                double price = double.Parse(input.Split(' ')[4]);

                                var items = dic.Where(i => i.Value.Price >= price)
                                .OrderBy(i => i.Value.Price)
                                .ThenBy(i => i.Key)
                                .ThenBy(i => i.Value.Type)
                                .Take(10)
                                .ToList();
                                if (items.Count == 0)
                                {
                                    Console.WriteLine("Ok: ");
                                }
                                else
                                {
                                    Console.Write("Ok: ");
                                    for (int i = 0; i < items.Count - 1; i++)
                                    {
                                        Console.Write($"{items[i].Key}({items[i].Value.Price:f2}), ");
                                    }
                                    Console.Write($"{items[items.Count - 1].Key}({items[items.Count - 1].Value.Price:f2})");
                                    Console.WriteLine();
                                }
                            }

                            else
                            {
                                double priceFrom = double.Parse(parameters[4]);
                                double priceTo = double.Parse(parameters[6]);

                                var items = dic.Where(i => i.Value.Price >= priceFrom && i.Value.Price <= priceTo)
                               .OrderBy(i => i.Value.Price)
                               .ThenBy(i => i.Key)
                               .ThenBy(i => i.Value.Type)
                               .Take(10)
                               .ToList();
                                if (items.Count == 0)
                                {
                                    Console.WriteLine("Ok: ");
                                }
                                else
                                {
                                    Console.Write("Ok: ");
                                    for (int i = 0; i < items.Count - 1; i++)
                                    {
                                        Console.Write($"{items[i].Key}({items[i].Value.Price:f2}), ");
                                    }
                                    Console.Write($"{items[items.Count - 1].Key}({items[items.Count - 1].Value.Price:f2})");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}