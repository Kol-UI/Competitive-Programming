// Good Prefixes
namespace CompetitiveProgramming.CodeForces.GoodPrefixes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        Console.SetIn(new System.IO.StreamReader(Console.OpenStandardInput()));
        Console.SetOut(new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });

        int tc = int.Parse(Console.ReadLine());
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            List<long> v = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            long currentSum = 0;
            long maxElement = 0;
            long goodPrefixesCount = 0;

            for (int i = 0; i < n; i++)
            {
                currentSum += v[i];
                maxElement = Math.Max(maxElement, v[i]);

                if (currentSum - maxElement == maxElement)
                {
                    goodPrefixesCount++;
                }
            }
            Console.WriteLine(goodPrefixesCount);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Good Prefixes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
	}
}