using System;
using System.Linq;

namespace Variations
{
    internal class Program
    {
        static int numberOfLoops;
        static char[] result;
        static void Main(string[] args)
        {
            numberOfLoops = int.Parse(Console.ReadLine());
            char[] chars = Console.ReadLine().Split(' ').Select(x => char.Parse(x)).ToArray();

            result = new char[numberOfLoops];

            char symbolOne = '\0';
            char symbolTwo = '\0';

            if (chars[0] >= chars[1])
            {
                symbolOne = chars[1];
                symbolTwo = chars[0];
            }
            else
            {
                symbolOne = chars[0];
                symbolTwo = chars[1];
            }


            Variation(symbolOne, symbolTwo, 0);
        }

        public static void Variation(char symbolOne, char symbolTwo, int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                Console.WriteLine(string.Join("", result));
                return;
            }

            result[currentLoop] = symbolOne;
            Variation(symbolOne, symbolTwo, currentLoop + 1);
            result[currentLoop] = symbolTwo;
            Variation(symbolOne, symbolTwo, currentLoop + 1);

        }

    }
}
