using System;
using System.Text;

namespace Change_Pi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = Recursive(input, 0);

            Console.WriteLine(result);
        }

        public static string Recursive(string str, int index)
        {
            StringBuilder sb = new StringBuilder();

            if (index >= str.Length)
            {
                return "";
            }

            else if (index < str.Length - 1 && str[index] == 'p' && str[index + 1] == 'i')
            {
                sb.Append("3.14" + Recursive(str, index + 2));
                return sb.ToString();

            }
            else
            {
                //xxpixa
                sb.Append(str[index].ToString() + Recursive(str, index + 1));
                return sb.ToString();
            }

        }
    }
}
