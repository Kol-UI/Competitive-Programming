using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.Watermelon
{
	public class Solution
	{
        public static void MainWatermelon(string[] args)
        {
            string? str = Console.ReadLine();
            var watermelon = new Watermelon(Int32.Parse(str!));
            Console.WriteLine(watermelon.Solve());
        }
    }

    internal class Watermelon
    {
        private readonly int _w;
        private const string Yes = "YES";
        private const string No = "NO";

        public Watermelon(int w)
        {
            _w = w;
        }

        public string Solve()
        {
            return IsEven() ? Yes : No;
        }

        private bool IsEven()
        {
            return _w % 2 == 0 && _w != 2;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Watermelon");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}