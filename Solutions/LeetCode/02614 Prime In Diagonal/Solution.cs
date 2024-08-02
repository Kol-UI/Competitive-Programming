// Prime In Diagonal


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.PrimeInDiagonal
{
    public class Solution
    {
        public static int DiagonalPrime(int[][] nums)
        {
            int max = 0;
            int n = nums.Length;
            for(int i = 0; i < n; i++)
            {
                if(IsPrime(nums[i][i]))
                    max = max > nums[i][i]? max:nums[i][i];
                if(IsPrime(nums[i][n-1-i]))
                    max = max > nums[i][n-1-i]? max:nums[i][n-1-i];
        } 
            return max;
        }

        public static bool IsPrime(int x)
        {
            if(x == 1) return false;
            for(int i = 2; i <= Math.Sqrt(x); i++)
            {
                if(x % i == 0) return false;
            }
            return true;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] matrix1 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 5, 6, 7 },
                new int[] { 9, 10, 11 }
            };

            int[][] matrix2 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 5, 17, 7 },
                new int[] { 9, 11, 10 },
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.DiagonalPrime(matrix1), 11),
                ResultTester.CheckResult<int>(Solution.DiagonalPrime(matrix2), 17),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2614");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}