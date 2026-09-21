// Belted Rooms
namespace CompetitiveProgramming.CodeForces.BeltedRooms;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            string nLine = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nLine)) nLine = Console.ReadLine();
            int n = int.Parse(nLine.Trim());

            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s)) s = Console.ReadLine();

            bool left = true, right = true;
            long cnt = 0;

            for (int p = 0; p < n; p++)
            {
                if (s[(n + p - 1) % n] == '-' || s[p % n] == '-')
                {
                    ++cnt;
                }
                if (s[p] == '<')
                {
                    right = false;
                }
                else if (s[p] == '>')
                {
                    left = false;
                }
            }

            if (left || right)
            {
                cnt = n;
            }

            Console.WriteLine(cnt);
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Belted Rooms");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}