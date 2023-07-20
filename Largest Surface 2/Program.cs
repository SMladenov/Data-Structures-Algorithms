using System;
using System.ComponentModel;
using System.Linq;

namespace Largest_Surface_2
{
    internal class Program
    {
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


            bool[,] visited = new bool[N, M];
            int largestSurface = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (!visited[r, c])
                    {
                        int surface = GetSurfaceLength(matrix, visited, r, c);
                        if (surface > largestSurface)
                        {
                            largestSurface = surface;
                        }
                    }
                }
            }

            Console.WriteLine(largestSurface);

        }

        static int GetSurfaceLength(int[,] matrix, bool[,] visited, int row, int col)
        {
            int result = 1;
            visited[row, col] = true;

            int current = matrix[row, col];

            //left
            if (col - 1 >= 0 && matrix[row, col - 1] == current && !visited[row, col - 1])
            {
                result += GetSurfaceLength(matrix, visited, row, col - 1);
            }

            //right
            if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == current && !visited[row, col + 1])
            {
                result += GetSurfaceLength(matrix, visited, row, col + 1);
            }

            //up
            if (row - 1 >= 0 && matrix[row - 1, col] == current && !visited[row - 1, col])
            {
                result += GetSurfaceLength(matrix, visited, row - 1, col);
            }

            //down
            if (row + 1 < matrix.GetLength(0) && matrix[row + 1, col] == current && !visited[row + 1, col])
            {
                result += GetSurfaceLength(matrix, visited, row + 1, col);
            }

            return result;
        }
    }
}
