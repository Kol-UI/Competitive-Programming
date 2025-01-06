// Minimum Number of Operations to Move All Balls to Each Box

namespace CompetitiveProgramming.LeetCode.MinimumNumberofOperationstoMoveAllBallstoEachBox;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] MinOperations(string boxes)
    {
        int n = boxes.Length;
        int[] distances = new int[n];

        int prefixCount = 0;
        int prefixSum = 0;
        int suffixCount = 0;
        int suffixSum = 0;

        for (int i = 0; i < n; i++)
        {
            distances[i] = prefixCount * i - prefixSum;
            if (boxes[i] == '1')
            {
                prefixCount++;
                prefixSum += i;
            }
        }

        for (int i = n - 1; i >= 0; i--)
        {
            distances[i] += suffixSum - suffixCount * i;
            if (boxes[i] == '1')
            {
                suffixCount++;
                suffixSum += i;
            }
        }

        return distances;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int[]>(solution.MinOperations("110"), new int[]{1,1,3}),
            ResultTester.CheckResult<int[]>(solution.MinOperations("001011"), new int[]{11,8,5,4,3,4})
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Number of Operations to Move All Balls to Each Box");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}