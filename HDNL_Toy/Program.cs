using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HDNL_Toy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int nested = 0;
            var s = new Stack<(int, char)>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var letter = input[0];
                var numberAsString = input.Remove(0, 1);
                var number = int.Parse(numberAsString);

                if (s.Count == 0)
                {
                    SbAppend(input, sb, nested);
                    s.Push((number, letter));
                    continue;
                }
                if (s.Count > 0)
                {
                    var lastElement = s.Peek();
                    if (lastElement.Item1 < number)
                    {
                        nested++;
                        s.Push((number, letter));
                        SbAppend(input, sb, nested);
                        continue;
                    }
                    if (lastElement.Item1 == number)
                    {
                        string str = lastElement.Item2.ToString() + lastElement.Item1.ToString();
                        SbAppend(str, sb, nested, true);
                        s.Pop();
                        s.Push((number, letter));
                        SbAppend(input, sb, nested);
                        continue;
                    }
                    if (lastElement.Item1 > number)
                    {
                        while (lastElement.Item1 >= number)
                        {
                            string str = lastElement.Item2.ToString() + lastElement.Item1.ToString();
                            SbAppend(str, sb, nested, true);
                            s.Pop();
                            nested--;
                            if (nested < 0)
                            {
                                nested = 0;
                            }
                            if (s.Count > 0)
                            {
                                lastElement = s.Peek();
                            }
                            else
                            {
                                break;
                            }

                        }
                        nested++;
                        if (s.Count == 0)
                            nested = 0;
                        s.Push((number, letter));
                        SbAppend(input, sb, nested);
                        continue;

                    }
                }
            }

            var countOfElementsToClose = s.Count;
            for (int i = 0; i < countOfElementsToClose; i++)
            {
                
                var element = s.Pop();
                string str = element.Item2.ToString() + element.Item1.ToString();
                SbAppend(str, sb, nested, true);
                //SbAppend()
                nested--;
                if (nested < 0)
                    nested = 0;
            }

            Console.WriteLine(sb.ToString());
        }
        private static void SbAppend(string input, StringBuilder sb, int nested, bool isClosed = false)
        {
            var str = string.Empty;
            if (isClosed)
            {
                str = new string(' ', nested) + $"</{input}>";
            }
            else
            {
                str = new string(' ', nested) + $"<{input}>";
            }

            sb.Append(str);
            sb.Append(Environment.NewLine);
        }
    }
}
