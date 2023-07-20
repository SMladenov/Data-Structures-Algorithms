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

            // if the current char is '7'
            if (str[index] == '7')
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
