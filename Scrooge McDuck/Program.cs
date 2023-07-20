using System;
using System.Linq;

namespace Scrooge_McDuck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int N = input[0];
            int M = input[1];

            int[,] matrix = new int[N, M];
            int rowStart = 0;
            int colStart = 0;

            for (int r = 0; r < N; r++)
            {
                int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                for (int c = 0; c < array.Length; c++)
                {
                    if (array[c] == 0)
                    {
                        rowStart = r;
                        colStart = c;
                    }
                    matrix[r, c] = array[c];
                }
            }

            //Print(matrix);

            Console.WriteLine(FindPath(rowStart, colStart, matrix));
            
        }

        public static bool InRange(int row, int col, int[,] matrix)
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
            if (rowInRange && colInRange)
            {
                return matrix[row, col] != 0;
            }
            else
            {
                return false;
            }
        }

        public static int FindPath(int row, int col, int[,] matrix)
        {
            int counter = 0;

            if (!InRange(row - 1, col, matrix) &&
                !InRange(row - 1, col - 1, matrix) &&
                !InRange(row - 1, col + 1, matrix) &&
                !InRange(row, col - 1, matrix) &&
                !InRange(row, col + 1, matrix) &&
                !InRange(row + 1, col - 1, matrix) &&
                !InRange(row + 1, col, matrix) &&
                !InRange(row + 1, col + 1, matrix))
            {
                return counter;
            }
          
            int L = 0;
            int R = 0;
            int U = 0;
            int D = 0;

            if (InRange(row, col - 1, matrix))
            {
                L = matrix[row, col - 1];
            }
            if (InRange(row, col + 1, matrix))
            {
                R = matrix[row, col + 1];
            }
            if (InRange(row - 1, col, matrix))
            {
                U = matrix[row - 1, col];
            }
            if (InRange(row + 1, col, matrix))
            {
                D = matrix[row + 1, col];
            }

            int maxCell = Math.Max(Math.Max(L,R), Math.Max(U, D));

            if (maxCell > 0)
            {
                if (L == maxCell)
                {
                    counter++;
                    matrix[row, col - 1]--;
                    return counter + FindPath(row, col - 1, matrix);
                }
                else if (R == maxCell)
                {
                    counter++;
                    matrix[row, col + 1]--;
                    return counter + FindPath(row, col + 1, matrix);
                }
                else if (U == maxCell)
                {
                    counter++;
                    matrix[row - 1, col]--;
                    return counter + FindPath(row - 1, col, matrix);
                }
                else if (D == maxCell)
                {
                    counter++;
                    matrix[row + 1, col]--;
                    return counter + FindPath(row + 1, col, matrix);
                }
            }
            return 0;
        }


        public static void Print(int[,] matrix)
        {
            Console.WriteLine(new string('-', 10));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
