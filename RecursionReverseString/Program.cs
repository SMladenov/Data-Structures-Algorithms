using System;

namespace RecursionReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Telerik"));
        }

        static string ReverseString(string str)
        {
            if (str.Length == 0)
            {
                return str;
            }

            return ReverseString(str.Substring(1)) + str[0];
        }
    }
}
