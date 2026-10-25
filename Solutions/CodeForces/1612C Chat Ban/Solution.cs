// Chat Ban
namespace CompetitiveProgramming.CodeForces.ChatBan;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static bool Check(long lines, long k, long x)
    {
        long total;
        if (lines <= k) total = lines * (lines + 1) / 2;
        else total = k * k - (2 * k - 1 - lines) * (2 * k - lines) / 2;
        return total < x;
    }

    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] first = Console.ReadLine().Split();
            long k = long.Parse(first[0]);
            long x = long.Parse(first[1]);

            long left = 0, right = 2 * k - 1, w = 2 * k - 1;
            while (left <= right)
            {
                long mid = (left + right) / 2;
                if (Check(mid, k, x)) left = mid + 1;
                else { w = mid; right = mid - 1; }
            }

            Console.WriteLine(w);
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
        StyleHelper.Title("Chat Ban");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}