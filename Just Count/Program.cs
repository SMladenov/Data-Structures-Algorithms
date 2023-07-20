using System;
using System.Collections.Generic;

namespace Just_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dicSymbols = new Dictionary<char, int>();
            var dicCharLower = new Dictionary<char, int>();
            var dicCharUpper = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    if (char.IsUpper(input[i]))
                    {
                        if (!dicCharUpper.ContainsKey(input[i]))
                        {
                            dicCharUpper.Add(input[i], 1);
                        }
                        else
                        {
                            int value = dicCharUpper[input[i]];
                            dicCharUpper[input[i]] = value + 1;
                        }
                    }

                    if (char.IsLower(input[i]))
                    {
                        if (!dicCharLower.ContainsKey(input[i]))
                        {
                            dicCharLower.Add(input[i], 1);
                        }
                        else
                        {
                            int value = dicCharLower[input[i]];
                            dicCharLower[input[i]] = value + 1;
                        }
                    }
                }

                else
                {
                    if (!dicSymbols.ContainsKey(input[i]))
                    {
                        dicSymbols.Add(input[i], 1);
                    }
                    else
                    {
                        int value = dicSymbols[input[i]];
                        dicSymbols[input[i]] = value + 1;
                    }
                }
            }

            Print(dicSymbols);
            Print(dicCharLower);
            Print(dicCharUpper);

        }

        public static void Print(Dictionary<char, int> dic)
        {
            if (dic.Count == 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                char resultChar = '\0';
                int resultInt = 0;
                char tempChar = '\0';

                foreach (var item in dic)
                {
                    if (resultInt < item.Value)
                    {
                        resultInt = item.Value;
                        resultChar = item.Key;
                    }
                    if (resultInt == item.Value)
                    {
                        tempChar = item.Key;
                        if (resultChar > tempChar) 
                        { 
                            resultChar = tempChar;
                        }
                    }

                }

                Console.WriteLine($"{resultChar} {resultInt}");
            }
        }
    }
}
