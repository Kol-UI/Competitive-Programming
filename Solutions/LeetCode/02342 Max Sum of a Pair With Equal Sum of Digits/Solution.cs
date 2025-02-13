// Max Sum of a Pair With Equal Sum of Digits

namespace CompetitiveProgramming.LeetCode.MaxSumofaPairWithEqualSumofDigits;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumSum(int[] nums)
    {
        if (nums.Length < 2)
            return -1;

        Dictionary<int, int[]> dict = new Dictionary<int, int[]>();
        int maxSum = -1;

        foreach (int n in nums)
        {
            int digitSum = GetDigitSum(n);

            if (!dict.ContainsKey(digitSum))
            {
                dict[digitSum] = new int[] { -1, n };
            }
            else
            {
                int first = dict[digitSum][0], second = dict[digitSum][1];

                if (n >= second)
                {
                    if (first > 0)
                        dict[digitSum] = new int[] { Math.Max(n, first), Math.Min(first, n) };
                    else
                        dict[digitSum] = new int[] { n, second };
                }
                else if (first == -1)
                {
                    dict[digitSum] = new int[] { second, n };
                }
            }

            if (dict[digitSum][0] > 0)
                maxSum = Math.Max(maxSum, dict[digitSum][0] + dict[digitSum][1]);
        }

        return maxSum;
    }

    private static int GetDigitSum(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Max Sum of a Pair With Equal Sum of Digits");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}