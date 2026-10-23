// Polygon
namespace CompetitiveProgramming.CodeForces.Polygon;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8601
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] m = new string[n];
            for (long p = 0; p < n; p++) m[p] = Console.ReadLine();

            bool possible = true;
            for (long row = 0; row + 1 < n; row++)
            {
                for (long col = 0; col + 1 < m[0].Length; col++)
                {
                    if (m[row][(int)col] == '0') continue;
                    if (m[row + 1][(int)col] == '0' && m[row][(int)(col + 1)] == '0')
                    {
                        possible = false;
                        break;
                    }
                }
                if (!possible) break;
            }

            Console.WriteLine(possible ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8601
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Polygon");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}