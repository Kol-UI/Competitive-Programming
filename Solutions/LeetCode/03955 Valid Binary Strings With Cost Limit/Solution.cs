// Valid Binary Strings With Cost Limit
namespace CompetitiveProgramming.CodeForces.ValidBinaryStringsWithCostLimit;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<string> GenerateValidStrings(int n, int k)
    {
        List<string> result = new();
        BackTrack(string.Empty);
        return result;

        void BackTrack(string cur)
        {
            if(cur.Length == n)
            {
                if(Cost(cur) <= k)
                {
                    result.Add(cur);
                }
                return ;
            }
            BackTrack(cur + '0');
            if(string.IsNullOrEmpty(cur))
            {
                BackTrack(cur + '1');
            }
            else if(!string.IsNullOrEmpty(cur) && cur[^1] != '1')
            {
                BackTrack(cur + '1');
            }
        }

        int Cost(string s)
        {
            int cost = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == '1')
                    cost += i;
                if(cost > k)
                    return cost;
            }
            return cost;
        }
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<IList<string>>(solution.GenerateValidStrings(3, 1), ["000","010","100"]),
            ResultTester.CheckResult<IList<string>>(solution.GenerateValidStrings(1, 0), ["0","1"]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Valid Binary Strings With Cost Limit");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}