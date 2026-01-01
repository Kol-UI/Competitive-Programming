// Beautiful String
namespace CompetitiveProgramming.CodeForces.BeautifulString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            
            List<int> positions = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0') positions.Add(i + 1);
            }
            
            Console.WriteLine(positions.Count);
            if (positions.Count > 0)
            {
                Console.WriteLine(string.Join(" ", positions));
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
        StyleHelper.Title("Beautiful String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}