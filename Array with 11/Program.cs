using System;
using System.Linq;

namespace Array_With_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(Recursive(array, index));

        }

        public static int Recursive(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                if (array[index] == 11)
                {
                    return 1;
                }
                return 0;
            }

            else if (array[index] == 11)
            {
                return 1 + Recursive(array, index + 1);
            }

            else
            {
                return Recursive(array, index + 1);
            }
        }

    }
}