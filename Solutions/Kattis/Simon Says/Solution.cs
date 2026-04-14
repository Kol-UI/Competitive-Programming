// Simon Says
namespace CompetitiveProgramming.Kattis.SimonSays;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        int times = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < times; i++)
        {
            string s = Console.ReadLine();
            if (s.StartsWith("Simon says"))
            {
                s = s.Remove(0, 11);
                Console.WriteLine(s);
            }
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Simon Says");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}