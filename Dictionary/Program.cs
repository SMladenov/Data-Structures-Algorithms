using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, int>();
            dic.Add("Bulgaria", 6000000);
            dic.Add("Germany", 8000000);
            //dic.Add("Bulgaria", 60000); //If trying to add without TryAdd and the key is existing, will throw exception
            dic.TryAdd("Bulgaria", 600000);

            dic["Bulgaria"] = 850000; //If we want to change value by searching the element by Key

            foreach (var item in dic) //If we want we can itterate through dic.Values or dic.Keys
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }



        }
    }
}
