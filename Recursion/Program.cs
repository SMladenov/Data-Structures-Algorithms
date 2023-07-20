using System;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursion is a method who calls himself

            //PrintNumber(5);
            //ItterativePrintNumber(5);

            Console.WriteLine(ItteractiveFactorial(4));
            Console.WriteLine(RecursiveFactorial(4));
        }

        static int RecursiveFactorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            return number * RecursiveFactorial(number - 1);
        }

        static int ItteractiveFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        //Itterative way to execute the code -- time 0(n), space - 0(1)
        static void ItterativePrintNumber(int number)
        {
            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        //When calling one method like this we want to know when to stop, so called basic case or bottom
        //time - 0(n), space - 0(n)
        static void PrintNumber(int number)
        {
            if (number == 0)
            {
                return;
            }

            Console.WriteLine(number);

            PrintNumber(number - 1);

            //Second CW wont be executed after calling the method in the method
            //Goes all the way as LIFO
            Console.WriteLine($"End of method for number {number}");
        }


    }
}
