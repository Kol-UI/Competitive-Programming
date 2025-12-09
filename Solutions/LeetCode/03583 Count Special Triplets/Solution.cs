// Count Special Triplets
namespace CompetitiveProgramming.LeetCode.CountSpecialTriplets;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SpecialTriplets(int[] nums)
    {
        const int M = 1000000007;
        int answer = 0;
        int length = nums.Length;

        var leftMap = new Dictionary<int, long>();
        var rightMap = nums.GroupBy(x => x).ToDictionary(g => g.Key, g => (long)g.Count());

        for (int position = 0; position < length - 1; position++)
        {
            int currentNumber = nums[position];
            rightMap[currentNumber]--;

            int doubled = 2 * currentNumber;

            if (leftMap.TryGetValue(doubled, out long leftCount) &&
                rightMap.TryGetValue(doubled, out long rightCount))
            {
                answer = (int)((answer + (leftCount * rightCount) % M) % M);
            }

            if (leftMap.ContainsKey(currentNumber))
                leftMap[currentNumber]++;
            else
                leftMap[currentNumber] = 1;
        }

        return answer;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.SpecialTriplets([6,3,6]), 1),
            ResultTester.CheckResult<int>(solution.SpecialTriplets([0,1,0,0]), 1),
            ResultTester.CheckResult<int>(solution.SpecialTriplets([8,4,2,8,4]), 2),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Special Triplets");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}