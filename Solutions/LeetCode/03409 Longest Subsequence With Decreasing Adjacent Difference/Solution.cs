// Longest Subsequence With Decreasing Adjacent Difference
namespace CompetitiveProgramming.LeetCode.LongestSubsequenceWithDecreasingAdjacentDifference;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public int LongestSubsequence(int[] nums) {
        int[,] dp = new int[301, 301];
        int[][] newValues = new int[301][];
        for (int i = 0; i < 301; i++) {
            newValues[i] = new int[2];
        }

        for (int k = 0, num = 0, n = 0; k < nums.Length; k++) {
            n = 0;
            num = nums[k];

            for (int i = 1; i < dp.GetLength(0); i++) {
                if (dp[i, 0] == 0) continue;
                int diff = Math.Abs(num - i);
                
                int max = diff == 0 ? dp[i, 0] : 1;
                if (dp[i, diff] > max) max = dp[i, diff];

                newValues[n][0] = diff;
                newValues[n][1] = max + 1;
                n++;
            }

            for (int i = 0; i < n; i++) {
                int diff = newValues[i][0];
                int max = newValues[i][1];

                for (int j = diff; j > -1; j--) {
                    if (max > dp[num, j]) {
                        dp[num, j] = max;
                    } else {
                        break;
                    }
                }
            }
            if (dp[num, 0] == 0) dp[num, 0] = 1;
        }

        int globalMax = 0;
        for (int i = 0; i < dp.GetLength(0); i++) {
            for (int j = 0; j < dp.GetLength(1); j++) {
                if (dp[i, j] > globalMax) globalMax = dp[i, j];
            }
        }

        return globalMax;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.LongestSubsequence(new int[]{16,6,3}), 3),
            ResultTester.CheckResult<int>(solution.LongestSubsequence(new int[]{6,5,3,4,2,1}), 4),
            ResultTester.CheckResult<int>(solution.LongestSubsequence(new int[]{10,20,10,19,10,20}), 5),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Subsequence With Decreasing Adjacent Difference");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}