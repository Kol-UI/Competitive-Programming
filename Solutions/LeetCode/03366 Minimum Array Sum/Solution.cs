// Minimum Array Sum
namespace CompetitiveProgramming.LeetCode.MinimumArraySum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinArraySum(int[] nums, int k, int op1, int op2)
    {
        int len = nums.Length;
        int[,,] dp = new int[len + 1, op1 + 1, op2 + 1];

        for(int i = 0; i <= len; i++)
        {
            for(int j = 0; j <= op1; j++)
            {
                for(int p = 0; p <= op2; p++)
                {
                    dp[i,j,p] = int.MaxValue;
                }
            }
        }

        dp[0, 0, 0] = 0;

        for (int i = 0; i < len; i++)
        {
            for (int opt1 = 0; opt1 <= op1; opt1++)
            {
                for (int opt2 = 0; opt2 <= op2; opt2++)
                {
                    int cur = dp[i, opt1, opt2];
                    if (cur == int.MaxValue)
                        continue;

                    dp[i + 1, opt1, opt2] = Math.Min(dp[i+1, opt1, opt2], cur+ nums[i]); // init
                    if (opt1 < op1)
                        dp[i + 1, opt1 + 1, opt2] = Math.Min(dp[i+1, opt1+1, opt2], cur + (nums[i]+1)/2); // opt 1

                    if (opt2 < op2 && nums[i] >= k)
                        dp[i + 1, opt1, opt2 + 1] = Math.Min(dp[i+1, opt1, opt2+1], cur + (nums[i]-k)); // opt 2

                    if (opt1 < op1 && opt2 < op2 && (nums[i] + 1) / 2 >= k)
                        dp[i + 1, opt1 + 1, opt2+1] = Math.Min(dp[i+1, opt1+1, opt2+1], cur + (nums[i]+1)/2-k); // opt 1 and opt 2 on same item

                    if (nums[i] >= k && opt1 < op1 && opt2 < op2)
                        dp[i + 1, opt1 + 1, opt2 + 1] = Math.Min(dp[i+1, opt1+1, opt2+1], cur + (nums[i]-k+1)/2); // opt 2 and opt 1 on same item
                }
            }
        }

        int res = int.MaxValue;
        for (int i = 0; i <= op1; i++)
        {
            for (int j = 0; j <= op2; j++)
            {
                res = Math.Min(res, dp[len, i, j]);
            }
        }

        return res;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Array Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}
