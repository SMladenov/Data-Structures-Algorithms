using System;
using System.Linq;

namespace Array_Values_times_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(Recursive(array, index).ToString().ToLower());
        }
                                             
        public static bool Recursive(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return false;
            }

            else if (index < array.Length - 1 && array[index + 1] == array[index] * 10)
            {
                return true;
            }

            else
            {
                return Recursive(array, index + 1);
            }

        }
    }
}
