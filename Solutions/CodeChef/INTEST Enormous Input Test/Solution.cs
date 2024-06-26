
using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.EnormousInputTest
{
    public class Solution
    {
        public static void MainTest()
        {
            string[] parts = Console.ReadLine()!.Split();
            uint n = UInt32.Parse(parts[0]);
            uint k = UInt32.Parse(parts[1]);
            uint ans = 0;

            for (uint i = 0; i < n; i++)
            {
                uint t = UInt32.Parse(Console.ReadLine()!);

                if (t%k == 0)
                    ans++;
            }

        Console.WriteLine(ans);
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Enormous Input Test");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}