
using System.Diagnostics;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Open brackets must be closed by the same type of brackets

            static bool isValid(string str)
            {
                var openingBrackets = new Stack<char>();
                //var timer = new Stopwatch();
                //timer.Start();

                foreach (var bracket in str)
                {
                    if (bracket == '(' || bracket == '[' || bracket == '{')
                    {
                        openingBrackets.Push(bracket);
                    }
                    else
                    {
                        if (openingBrackets.Count == 0)
                        {
                            return false;
                        }
                        var openingBracket = openingBrackets.Pop();
                        // (), [], {}
                        if (!(openingBracket == '(' && bracket == ')') ||
                            !(openingBracket == '[' && bracket == ']') ||
                            !(openingBracket == '{' && bracket == '}'))
                        {
                            return false;
                        }
                    }
                }
                return openingBrackets.Count == 0;

                //timer.Stop();
                //Console.WriteLine(timer.ElapsedMilliseconds);
            }
        }
    }
}