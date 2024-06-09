// Birthday Cake Candles



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.BirthdayCakeCandles
{
    class Result
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            int count = candles.Count(x => x == max);
            return count;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Birthday Cake Candles");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerRank, ProblemCategory.EasyHR);
        }
    }
}