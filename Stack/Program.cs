using System;
using System.Collections;
using System.Text;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack<string> word = new Stack<string>();
            //word.Push("a");
            //word.Push("r");
            //word.Push("e");
            //word.Push("b");
            //word.Push("e");

            //foreach (string w in word)
            //{
            //    Console.Write(w);
            //}
            //Console.WriteLine();
            Console.WriteLine(RemoveBackspaces("abcd#e#", '#'));

        }

        public static string RemoveBackspaces(string sequence, char backspaceChar)
        {
            Stack<string> stack = new Stack<string>();

            string sb = string.Empty;
            

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] != '#')
                {
                    stack.Push(sequence[i].ToString());
                }
                else
                {
                    stack.Pop();
                }
            }
            var finalStack = stack.Reverse();

            foreach (var s in finalStack)
            {
                sb += s;
            }
            
            
            return sb;
        }
    }
}