// How good are you really


using System;
using System.Linq;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeWars.EightKyu.Howgoodareyoureally
{
    public class Kata
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            int[] allPoints = ClassPoints.Concat(new[] { YourPoints }).ToArray();
            double classAverage = allPoints.Average();
            return YourPoints > classAverage;
        }

        public static bool BetterThanAverage2(int[] ClassPoints, int YourPoints)
        {
            return YourPoints > ClassPoints.Average();
        }

        public static bool BetterThanAverage3(int[] ClassPoints, int YourPoints)
        {
            return ClassPoints.Average() < YourPoints;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Kata.BetterThanAverage(new int[]{2,3}, 5), true),
                ResultTester.CheckResult<bool>(Kata.BetterThanAverage(new int[]{100, 40, 34, 57, 29, 72, 57, 88}, 75), true),
                ResultTester.CheckResult<bool>(Kata.BetterThanAverage(new int[]{12,23,34,45,56,67,78,89,90}, 69), true),

                ResultTester.CheckResult<bool>(Kata.BetterThanAverage2(new int[]{2,3}, 5), true),
                ResultTester.CheckResult<bool>(Kata.BetterThanAverage2(new int[]{100, 40, 34, 57, 29, 72, 57, 88}, 75), true),
                ResultTester.CheckResult<bool>(Kata.BetterThanAverage2(new int[]{12,23,34,45,56,67,78,89,90}, 69), true),

                ResultTester.CheckResult<bool>(Kata.BetterThanAverage3(new int[]{2,3}, 5), true),
                ResultTester.CheckResult<bool>(Kata.BetterThanAverage3(new int[]{100, 40, 34, 57, 29, 72, 57, 88}, 75), true),
                ResultTester.CheckResult<bool>(Kata.BetterThanAverage3(new int[]{12,23,34,45,56,67,78,89,90}, 69), true),
            };

            return results;
        }
    }
}