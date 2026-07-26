// Concatenate Non-Zero Digits and Multiply by Sum II
namespace CompetitiveProgramming.LeetCode.ConcatenateNonZeroDigitsandMultiplybySumII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private const long Mod = 1_000_000_007;

    public int[] SumAndMultiply(string digits, int[][] queries)
    {
        int length = digits.Length;

        int[] nonZeroPrefixCount = new int[length];

        long[] nonZeroNumberPrefix = new long[length];

        long[] digitSumPrefix = new long[length];

        long[] powerOf10 = new long[length + 1];
        powerOf10[0] = 1;

        for (int i = 1; i <= length; i++)
        {
            powerOf10[i] = (powerOf10[i - 1] * 10) % Mod;
        }

        int firstDigit = digits[0] - '0';

        nonZeroPrefixCount[0] = firstDigit == 0 ? 0 : 1;
        nonZeroNumberPrefix[0] = firstDigit;
        digitSumPrefix[0] = firstDigit;

        for (int i = 1; i < length; i++)
        {
            int digit = digits[i] - '0';

            nonZeroPrefixCount[i] =
                nonZeroPrefixCount[i - 1] + (digit == 0 ? 0 : 1);

            if (digit == 0)
            {
                nonZeroNumberPrefix[i] = nonZeroNumberPrefix[i - 1];
            }
            else
            {
                nonZeroNumberPrefix[i] =
                    (nonZeroNumberPrefix[i - 1] * 10 + digit) % Mod;
            }

            digitSumPrefix[i] = digitSumPrefix[i - 1] + digit;
        }

        int[] answer = new int[queries.Length];

        for (int queryIndex = 0; queryIndex < queries.Length; queryIndex++)
        {
            int left = queries[queryIndex][0];
            int right = queries[queryIndex][1];

            int nonZeroBeforeLeft =
                left == 0 ? 0 : nonZeroPrefixCount[left - 1];

            long prefixNumberBeforeLeft =
                left == 0 ? 0 : nonZeroNumberPrefix[left - 1];

            int nonZeroDigitsInRange =
                nonZeroPrefixCount[right] - nonZeroBeforeLeft;

            if (nonZeroDigitsInRange == 0)
            {
                answer[queryIndex] = 0;
                continue;
            }

            long extractedNumber =
                (
                    nonZeroNumberPrefix[right]
                    - (prefixNumberBeforeLeft * powerOf10[nonZeroDigitsInRange]) % Mod
                    + Mod
                ) % Mod;

            long digitSum =
                digitSumPrefix[right]
                - (left == 0 ? 0 : digitSumPrefix[left - 1]);

            answer[queryIndex] = (int)((extractedNumber * digitSum) % Mod);
        }

        return answer;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.SumAndMultiply("10203004", [[0,7],[1,3],[4,6]]), [12340, 4, 9]),
            ResultTester.CheckResult<int[]>(solution.SumAndMultiply("1000", [[0,3],[1,1]]), [1, 0]),
            ResultTester.CheckResult<int[]>(solution.SumAndMultiply("9876543210", [[0,9]]), [444444137]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Concatenate Non-Zero Digits and Multiply by Sum II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}