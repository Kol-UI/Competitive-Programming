// Minimum Number of Groups to Create a Valid Assignment
namespace CompetitiveProgramming.LeetCode.MinimumNumberofGroupstoCreateaValidAssignment;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinGroupsForValidAssignment(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var v = nums[i];

            if (!dict.TryAdd(v, 1))
            {
                dict[v]++;
            }
        }

        int minGroup = dict.Values.Min();

        for (int i = minGroup; i >= 1; i--)
        {
            var f = find(i, dict);

            if (f > 0)
            {
                return f;
            }
        }
        return dict.Keys.Count();

        int find(int bucket, Dictionary<int, int> dict)
        {
            int count = 0;

            foreach (var value in dict.Values)
            {
                if (value % (bucket + 1) == 0)
                {
                    count += value / (bucket + 1);
                }
                else if (value / (bucket + 1) + value % (bucket + 1) >= bucket)
                {
                    count += value / (bucket + 1) + 1;
                }
                else
                {
                    return 0;
                }
            }

            return count;
        }
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinGroupsForValidAssignment([3,2,3,2,3]), 2),
            ResultTester.CheckResult<int>(solution.MinGroupsForValidAssignment([10,10,10,3,1,1]), 4)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Number of Groups to Create a Valid Assignment");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}