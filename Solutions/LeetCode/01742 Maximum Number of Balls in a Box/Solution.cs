// Maximum Number of Balls in a Box
namespace CompetitiveProgramming.LeetCode.MaximumNumberofBallsinaBox;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountBalls(int lowLimit, int highLimit)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int maxFreq = 0;
        for (int i = lowLimit; i <= highLimit; i++)
        {
            int currentSum = sumOfNumbersOfBall(i);
            dict.TryAdd(currentSum, 0);
            dict[currentSum]++;
            maxFreq = Math.Max(maxFreq, dict[currentSum]);
        }

        return maxFreq;
    }

    public int sumOfNumbersOfBall(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int reminder = num % 10;
            sum += reminder;
            num /= 10;
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
            ResultTester.CheckResult<int>(solution.CountBalls(1, 10), 2),
            ResultTester.CheckResult<int>(solution.CountBalls(5, 15), 2),
            ResultTester.CheckResult<int>(solution.CountBalls(19, 28), 2),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Balls in a Box");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}