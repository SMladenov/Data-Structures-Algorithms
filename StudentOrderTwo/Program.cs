

using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections;
using System.Linq.Expressions;
using System.Collections.Concurrent;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> list = Console.ReadLine().Split(' ').ToList();

         
            int seatChanges = int.Parse(input.Split(' ')[1]);

            var d = new Dictionary<string, int>();


            var val = new Dictionary<int, string>();

            for (int i = 0; i < list.Count; i++)
            {
                d.Add(list[i], i);
                val.Add(i, list[i]);
            }

            for(int i = 0; i< seatChanges; i++)
            {

                var sw = Console.ReadLine().Split(' ').ToList();

               // var firstName = sw[0];
                //var secondName = sw[1];
                //Misho Gosho]
          
                var indexOfFirstStudent = d[sw[0]];
                var indexOfSecondStudent = d[sw[1]];
                
                if(indexOfSecondStudent < indexOfFirstStudent)
                {
                    for (int y = indexOfFirstStudent; y > indexOfSecondStudent; y--)
                    {
                        val[y] = val[y - 1];
                    }

                    val[indexOfSecondStudent] = sw[0];

                    for (int z = indexOfSecondStudent; z <= indexOfFirstStudent; z++)
                    {
                        //var n = val[z];
                        //d[n] = z;
                        d[val[z]] = z;
                    }
                }
                if(indexOfFirstStudent < indexOfSecondStudent)
                {
                    for (int z = indexOfFirstStudent; z < indexOfSecondStudent; z++)
                    {
                        val[z] = val[z + 1];
                    }

                    val[indexOfSecondStudent - 1] = sw[0];

                    for(int a = indexOfFirstStudent; a <= indexOfSecondStudent; a++)
                    {
                        //var n = val[a];
                        //d[n] = a;
                        d[val[a]] = a;
                    }
                }
            }


            foreach (var item in val)
            {
                Console.Write(item.Value + " ");
            }
           
        }
    }
}