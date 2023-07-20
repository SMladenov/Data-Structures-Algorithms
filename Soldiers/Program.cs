using System;
using System.Collections.Generic;
using System.Linq;

namespace Soldiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSoldiers = int.Parse(Console.ReadLine());
            List<string> input = Console.ReadLine().Split(' ').ToList();

            List<string> sergeant = new List<string>();
            List<string> corporal = new List<string>();
            List<string> privates = new List<string>();

            foreach (var soldier in input)
            {
                if (soldier.StartsWith("S"))
                {
                    sergeant.Add(soldier);
                }
                else if (soldier.StartsWith("C"))
                {
                    corporal.Add(soldier);
                }
                else if (soldier.StartsWith("P"))
                {
                    privates.Add(soldier);
                }
            }

            var allSoldiers = new List<string>(sergeant.Count +
                                    corporal.Count +
                                    privates.Count);
            allSoldiers.AddRange(sergeant);
            allSoldiers.AddRange(corporal);
            allSoldiers.AddRange(privates);
            //Array.Copy(privates, 0, result, soldiers.Length, soldiers.Length);

            Console.WriteLine(string.Join(" ", allSoldiers));

        }
    }
}
