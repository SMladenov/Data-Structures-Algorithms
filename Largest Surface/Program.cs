using System;
using System.ComponentModel;
using System.Linq;

namespace Largest_Surface
{
    internal class Program
    {
        public static bool[,] visited;
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int N = input[0];
            int M = input[1];

            int[,] matrix = new int[N, M];


            for (int r = 0; r < N; r++)
            {
                int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                for (int c = 0; c < array.Length; c++)
                {
                    matrix[r, c] = array[c];
                }
            }

            int tempresult = 0;
            int result = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    visited = new bool[N, M];
                    tempresult = FindPath(r, c, matrix);

                    if (result < tempresult)
                    {
                        result = tempresult;

                    }
                }
            }

            Console.WriteLine(result + 1);

        }

        public static bool InRange(int row, int col, int currentNumber, int[,] matrix)
        {
            bool rowInRange = false;
            bool colInRange = false;
            if (row >= 0 && row < matrix.GetLength(0))
            {
                rowInRange = true;
            }
            if (col >= 0 && col < matrix.GetLength(1))
            {
                colInRange = true;
            }
            if (rowInRange && colInRange && visited[row, col] == false)
            {
              
                return matrix[row, col] == currentNumber;
            }
            else
            {
                return false;
            }
        }

        public static int FindPath(int row, int col, int[,] matrix)
        {
            int counter = 0;

            //Left
            if (InRange(row, col - 1, matrix[row, col], matrix))
            {
                counter++;
                visited[row, col] = true;
                counter += FindPath(row, col - 1, matrix);
            }
            //right
            if (InRange(row, col + 1, matrix[row, col], matrix))
            {
                counter++;
                visited[row, col] = true;
                counter += FindPath(row, col + 1, matrix);
            }
            //up
            if (InRange(row - 1, col, matrix[row, col], matrix))
            {
                counter++;
                visited[row, col] = true;
                counter += FindPath(row - 1, col, matrix);
            }
            //down
            if (InRange(row + 1, col, matrix[row, col], matrix))
            {
                counter++;
                visited[row, col] = true;
                counter += FindPath(row + 1, col, matrix);
            }

         
            return counter;

        }




        //public static void Print(int[,] matrix)
        //{
        //    Console.WriteLine(new string('-', 10));
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            Console.Write(matrix[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
