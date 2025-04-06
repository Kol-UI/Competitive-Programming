// 2-Letter Strings
namespace CompetitiveProgramming.CodeForces.TwoLetterStrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            string[] v = new string[n];
            Dictionary<string, long> all = new Dictionary<string, long>();
            Dictionary<char, long> first = new Dictionary<char, long>();
            Dictionary<char, long> second = new Dictionary<char, long>();

            for (int i = 0; i < n; i++)
            {
                v[i] = Console.ReadLine()!;
                if (!all.ContainsKey(v[i])) all[v[i]] = 0;
                all[v[i]]++;
                
                char f = v[i][0];
                if (!first.ContainsKey(f)) first[f] = 0;
                first[f]++;
                
                char s = v[i][1];
                if (!second.ContainsKey(s)) second[s] = 0;
                second[s]++;
            }

            long cnt = 0;
            for (int i = 0; i < n; i++)
            {
                cnt += Math.Max(0, first[v[i][0]] - all[v[i]]);
                cnt += Math.Max(0, second[v[i][1]] - all[v[i]]);
                
                if (all[v[i]] > 0) all[v[i]]--;
                if (first[v[i][0]] > 0) first[v[i][0]]--;
                if (second[v[i][1]] > 0) second[v[i][1]]--;
            }
            Console.WriteLine(cnt);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("2-Letter Strings");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}