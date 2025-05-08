// Two Teams Composing
namespace CompetitiveProgramming.CodeForces.TwoTeamsComposing;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            string[] input = Console.ReadLine()!.Split();
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(input[i]);
                if (dict.ContainsKey(x))
                    dict[x]++;
                else
                    dict[x] = 1;
            }

            List<int> counts = dict.Values.ToList();
            counts.Sort((a, b) => b.CompareTo(a));

            int a = counts[0];
            int b = counts.Count;
            if (a == b) a--;

            Console.WriteLine(Math.Min(a, b));
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Two Teams Composing");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}