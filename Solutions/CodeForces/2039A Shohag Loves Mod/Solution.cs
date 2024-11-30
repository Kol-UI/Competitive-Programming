// Shohag Loves Mod
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#nullable disable
namespace CompetitiveProgramming.CodeForces.ShohagLovesMod
{
    using System;
    using System.Linq;

    public class Program
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine());
            for (int tc = 0; tc < t; ++tc)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(Solve(n));
            }
        }

        static string Solve(int n)
        {
            return string.Join(" ", Enumerable.Range(0, n)
                .Select(i => (2 * i + 1).ToString()));
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shohag Loves Mod");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}
#nullable enable