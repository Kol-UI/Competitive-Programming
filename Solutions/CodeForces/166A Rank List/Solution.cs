// Rank List
namespace CompetitiveProgramming.CodeForces.RankList;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        const int mult = 100;
        var firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = firstLine[0];
        int k = firstLine[1];
        
        int[] scores = new int[n];
        
        for(int p = 0; p < n; p++)
        {
            var parts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int solved = parts[0];
            int penalty = parts[1];
            scores[p] = mult * solved - penalty;
        }
        
        Array.Sort(scores);
        int targetScore = scores[n - k];
        int result = 0;
        
        for(int p = 0; p < n; p++)
        {
            if(scores[p] == targetScore) result++;
        }
        
        Console.WriteLine(result);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rank List");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}