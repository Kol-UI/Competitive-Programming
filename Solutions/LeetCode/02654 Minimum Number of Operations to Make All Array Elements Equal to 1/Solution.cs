// Minimum Number of Operations to Make All Array Elements Equal to 1
namespace CompetitiveProgramming.CodeForces.MinimumNumberofOperationstoMakeAllArrayElementsEqualto1;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinOperations(int[] nums)
    {
        int n = nums.Length;
        int num1 = 0;
        int g = 0;
        foreach (int x in nums)
        {
            if (x == 1)
            {
                num1++;
            }
            g = GCD(g, x);
        }
        if (num1 > 0)
        {
            return n - num1;
        }
        if (g > 1)
        {
            return -1;
        }

        int minLen = n;
        for (int i = 0; i < n; i++)
        {
            int currentGcd = 0;
            for (int j = i; j < n; j++)
            {
                currentGcd = GCD(currentGcd, nums[j]);
                if (currentGcd == 1)
                {
                    minLen = Math.Min(minLen, j - i + 1);
                    break;
                }
            }
        }
        return minLen + n - 2;
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinOperations([2,6,3,4]), 4),
            ResultTester.CheckResult<int>(solution.MinOperations([2,10,6,14]), -1)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Number of Operations to Make All Array Elements Equal to 1");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}