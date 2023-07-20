using System;

namespace CountXRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var str = Console.ReadLine();
            Console.WriteLine(CountX(str, 0));

        }

        static int CountX(string str, int index)
        {
            if (index == str.Length)
            {
                return 0;
            }

            // if current char is 'x'
            if (str[index] == 'x')
            {
                return 1 + CountX(str, index+1);
            }

            // if current char is not 'x'
            return CountX(str, index+1);
        }
    }
}
