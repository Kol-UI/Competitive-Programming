// Count Special Subsequences
namespace CompetitiveProgramming.LeetCode.CountSpecialSubsequences;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long NumberOfSubsequences(int[] nums)
    {
        int len = nums.Length;
        long res = 0;
        if(len < 7)
            return res;

        Dictionary<double, int> dict = new();
        
        for(int r = 4; r < len-2; r++)
        {
            int q = r-2;
            for(int p = 0; p < q-1; p++)
            {
                double dis = ((double)nums[p]/(double)nums[q]);
                if(!dict.ContainsKey(dis))
                    dict.Add(dis, 1);
                else 
                    dict[dis]++;
            }

            for(int s = r+2; s < len; s++)
            {
                double dis = ((double)nums[s]/(double)nums[r]);
                if(dict.ContainsKey(dis))
                    res += dict[dis];
            }
        }

        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long>(solution.NumberOfSubsequences(new int[]{1,2,3,4,3,6,1}), 1),
            ResultTester.CheckResult<long>(solution.NumberOfSubsequences(new int[]{3,4,3,4,3,4,3,4}), 3),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Special Subsequences");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}