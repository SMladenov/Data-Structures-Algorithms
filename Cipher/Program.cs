using System;
using System.Collections.Generic;

namespace Cipher
{
    internal class Program
    {
        static string[] output;
        static void Main(string[] args)
        {
            string secretMessage = Console.ReadLine();
            string cipher = Console.ReadLine();

            var dic = new Dictionary<char, string>();

            output = new string[1000];

            var currentChar = cipher[0];
            var currentValue = string.Empty;

            for (int i = 1; i < cipher.Length; i++)
            {
                if (char.IsLetter(cipher[i]))
                {
                    dic.Add(currentChar, currentValue);
                    currentChar = cipher[i];
                    currentValue = string.Empty;
                }
                else
                {
                    currentValue += cipher[i];
                }

            }
            dic.Add(currentChar, currentValue);

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
            FindMatches(dic, secretMessage, 0);
            
        }

        public static void FindMatches(Dictionary<char, string> dic, string secretMessage, int index)
        {
            if (index == secretMessage.Length)
            {
                Console.WriteLine(string.Join("", output));
                return;
            }
            foreach (var item in dic)
            {
                if (item.Value.Equals(secretMessage[index].ToString()))
                {
                    output[index] = item.Key.ToString();
                    FindMatches(dic, secretMessage, index + 1);
                }
            }
            //foreach (var item in dic)
            //{
            //    if (secretMessage.StartsWith(item.Value))
            //    {
            //        output[index] = item.Key.ToString();
            //        FindMatches(dic, secretMessage.Substring(item.Value.Length), index + 1);
            //    }
            //}

            //result[currentLoop] = symbolOne;
            //Variation(symbolOne, symbolTwo, currentLoop + 1);
            //result[currentLoop] = symbolTwo;
            //Variation(symbolOne, symbolTwo, currentLoop + 1);

        }
    }
}
