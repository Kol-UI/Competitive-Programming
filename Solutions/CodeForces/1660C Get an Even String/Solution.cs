// Get an Even String
namespace CompetitiveProgramming.CodeForces.GetanEvenString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string s = Console.ReadLine();
            long rem = s.Length;
            HashSet<char> obs = new HashSet<char>();

            for (long p = 0; p < s.Length; p++)
            {
                if (obs.Contains(s[(int)p]))
                {
                    rem -= 2;
                    obs.Clear();
                }
                else
                {
                    obs.Add(s[(int)p]);
                }
            }

            Console.WriteLine(rem);
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
        StyleHelper.Title("Get an Even String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}