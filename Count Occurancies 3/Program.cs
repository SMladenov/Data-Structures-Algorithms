using System;

namespace Count_Occurancies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = (Console.ReadLine());

            Console.WriteLine(Recursive(str, 0));
        }

        public static int Recursive(string str, int index)
        {

            if (index == str.Length)
            {
                return 0;
            }

            // if the current char is '8289'

            if (index < str.Length - 1 && str[index] == '8' && str[index + 1] == '8')
            {
                return 3 + Recursive(str, index + 2);
            }

            else if (str[index] == '8')
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