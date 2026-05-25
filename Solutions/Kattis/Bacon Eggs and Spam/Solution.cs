// Bacon, Eggs, and Spam
namespace CompetitiveProgramming.Kattis.BaconEggsandSpam;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            if (n == 0) break;

            Dictionary<string, List<string>> foods = new Dictionary<string, List<string>>();
            List<string> sortable = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] vars = Console.ReadLine().Split();
                string name = vars[0];
                
                for (int j = 1; j < vars.Length; j++)
                {
                    string food = vars[j];
                    if (!foods.ContainsKey(food))
                    {
                        foods[food] = new List<string>();
                        sortable.Add(food);
                    }
                    foods[food].Add(name);
                }
            }

            sortable.Sort();

            foreach (string food in sortable)
            {
                Console.Write($"{food} ");
                foods[food].Sort();
                Console.WriteLine(string.Join(" ", foods[food]));
            }

            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bacon, Eggs, and Spam");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}