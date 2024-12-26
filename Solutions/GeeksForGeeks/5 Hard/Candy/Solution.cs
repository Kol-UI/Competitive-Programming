// Candy


using System;
using System.Linq;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Hard.Candy
{
    class Solution
    {
        public static int MinCandy(int N, int[] ratings)
        {
            int[] leftToRight = new int[N];
            int[] rightToLeft = new int[N];
            
            for (int i = 0; i < N; i++)
            {
                leftToRight[i] = 1;
                rightToLeft[i] = 1;
            }
            
            for (int i = 1; i < N; i++)
            {
                if (ratings[i] > ratings[i - 1])
                    leftToRight[i] = leftToRight[i - 1] + 1;
            }
            
            for (int i = N - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                    rightToLeft[i] = rightToLeft[i + 1] + 1;
            }
            
            int totalCandies = 0;
            
            for (int i = 0; i < N; i++)
            {
                totalCandies += Math.Max(leftToRight[i], rightToLeft[i]);
            }
            
            return totalCandies;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] ratings1 = { 1, 2, 3, 4, 5 };
            int[] ratings2 = { 5, 4, 3, 2, 1 };
            int[] ratings3 = { 2, 2, 2, 2, 2 };
            int[] ratings4 = { 1, 3, 5, 2, 4, 6 };
            int[] ratings5 = { 5 };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinCandy(ratings1.Length, ratings1), 15),
                ResultTester.CheckResult<int>(Solution.MinCandy(ratings2.Length, ratings2), 15),
                ResultTester.CheckResult<int>(Solution.MinCandy(ratings3.Length, ratings3), 5),
                ResultTester.CheckResult<int>(Solution.MinCandy(ratings4.Length, ratings4), 12),
                ResultTester.CheckResult<int>(Solution.MinCandy(ratings5.Length, ratings5), 1),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Candy");
            ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.HardGFG, Test.TestCases());
        }
    }
}