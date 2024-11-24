// Maximum Matrix Sum

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumMatrixSum
{
    public class Solution
    {
        public long MaxMatrixSum(int[][] matrix)
        {
            int threshold = 0;
            long absoluteSum = 0;
            int negativeCount = 0;
            long smallestAbsoluteValue = long.MaxValue;
            
            foreach (var row in matrix)
            {
                foreach (int value in row)
                {
                    int absoluteValue = Math.Abs(value);
                    absoluteSum += absoluteValue;
                    smallestAbsoluteValue = Math.Min(smallestAbsoluteValue, absoluteValue);
                    
                    if (value < threshold)
                    {
                        negativeCount++;
                    }
                }
            }
            
            if (negativeCount % 2 == threshold)
            {
                return absoluteSum;
            }
            
            return absoluteSum - 2 * smallestAbsoluteValue;
        }
    }
    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();

            int[][] matrix1 = new int[][]
            {
                new int[] { 1, -1 },
                new int[] { -1, 1 }
            };
            long expected1 = 4;

            int[][] matrix2 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { -1, -2, -3 },
                new int[] { 1, 2, 3 }
            };
            long expected2 = 16;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(solution.MaxMatrixSum(matrix1), expected1),
                ResultTester.CheckResult<long>(solution.MaxMatrixSum(matrix2), expected2)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Matrix Sum");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}