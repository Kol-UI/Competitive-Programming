// Detailed Differences
namespace CompetitiveProgramming.Kattis.DetailedDifferences;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < t; i++)
        {
            string s = Console.ReadLine().Trim();
            string tStr = Console.ReadLine().Trim();
            
            Console.WriteLine(s);
            Console.WriteLine(tStr);
            
            char[] result = new char[s.Length];
            for (int j = 0; j < s.Length; j++)
            {
                result[j] = (s[j] != tStr[j]) ? '*' : '.';
            }
            
            Console.WriteLine(new string(result));
            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Detailed Differences");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}