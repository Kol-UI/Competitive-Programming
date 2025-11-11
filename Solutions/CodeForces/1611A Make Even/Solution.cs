// Make Even
namespace CompetitiveProgramming.CodeForces.MakeEven;using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            string s = Console.ReadLine()!;
            string result = "2";
            bool hasEven = false;
            
            foreach (char c in s)
            {
                if ((c - '0') % 2 == 0)
                {
                    hasEven = true;
                    break;
                }
            }
            
            if (!hasEven) result = "-1";
            else if ((s[s.Length - 1] - '0') % 2 == 0) result = "0";
            else if ((s[0] - '0') % 2 == 0) result = "1";
            
            Console.WriteLine(result);
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
        StyleHelper.Title("Make Even");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}