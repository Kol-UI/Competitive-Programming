// Find the Punishment Number of an Integer

namespace CompetitiveProgramming.LeetCode.FindthePunishmentNumberofanInteger;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int PunishmentNumber(int n)
    {
        var result = 0;
        for (int i = 1; i <= n; i++) 
        {
            if (SumOfPartitionesEquilsToNumber(i * i, i))  result += i * i;
        }

        return result;
    }

    private bool SumOfPartitionesEquilsToNumber(int partition, int number) 
    {
        if (partition == number) return true;
        if (number < 0) return false;

        int divisor = 10;
        while (divisor <= partition) 
        {
            int leftPart = partition / divisor;
            int rightPart = partition % divisor;
            if (SumOfPartitionesEquilsToNumber(leftPart, number - rightPart) || SumOfPartitionesEquilsToNumber(rightPart, number - leftPart))
                return true;

            divisor *= 10;
        }

        return false;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.PunishmentNumber(10), 182),
            ResultTester.CheckResult<int>(solution.PunishmentNumber(37), 1478)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Punishment Number of an Integer");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}