// Input Scandal
namespace CompetitiveProgramming.Kattis.InputScandal;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;
using System.Text;

class Solution
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string line;
        int count = 0;
        while ((line = Console.ReadLine()) != null)
        {
            count++;
            sb.Append(line);
            sb.Append('\n');
        }

        Console.WriteLine(count);
        Console.Write(sb.ToString());
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Input Scandal");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}