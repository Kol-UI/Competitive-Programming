// Four Divisors
namespace CompetitiveProgramming.LeetCode.FourDivisors;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SumFourDivisors(int[] nums)
    {
        int sum = 0;

        foreach (int num in nums)
        {
            int divisorSum = 0;
            int divisorCount = 0;

            for (int i = 1; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (i * i == num)
                    {
                        divisorSum += i;
                        divisorCount++;
                    }
                    else
                    {
                        divisorSum += i + num / i;
                        divisorCount += 2;
                    }

                    if (divisorCount > 4)
                    {
                        break;
                    }
                }
            }

            if (divisorCount == 4)
            {
                sum += divisorSum;
            }
        }

        return sum;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.SumFourDivisors([21,4,7]), 32),
            ResultTester.CheckResult<int>(solution.SumFourDivisors([21,21]), 64),
            ResultTester.CheckResult<int>(solution.SumFourDivisors([1,2,3,4,5]), 0),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Four Divisors");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}