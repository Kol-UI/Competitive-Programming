// Hay Points
namespace CompetitiveProgramming.Kattis.HayPoints;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int m = int.Parse(firstLine[0]);
        int n = int.Parse(firstLine[1]);
        
        Dictionary<string, int> score = new Dictionary<string, int>();
        for (int i = 0; i < m; i++)
        {
            string[] input = Console.ReadLine().Split();
            string w = input[0];
            int s = int.Parse(input[1]);
            score[w] = s;
        }
        
        for (int i = 0; i < n; i++)
        {
            int ans = 0;
            while (true)
            {
                string ws = Console.ReadLine().Trim();
                if (ws == ".")
                    break;
                
                string[] words = ws.Split(' ');
                foreach (string w in words)
                {
                    if (score.ContainsKey(w))
                        ans += score[w];
                }
            }
            Console.WriteLine(ans);
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Hay Points");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}