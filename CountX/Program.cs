using System;

namespace CountX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(Recursive(input, 0));
        }

        public static int Recursive(string str, int index)
        {
            if (index == str.Length)
            {
                return 0;
            }

            if (str[index] == 'x')
            {
                return 1 + Recursive(str, index + 1);
            }

            else
            {
                return Recursive(str, index + 1);
            }
        }
    }
}
