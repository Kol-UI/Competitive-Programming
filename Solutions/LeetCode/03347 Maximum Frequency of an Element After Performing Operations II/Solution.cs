// Maximum Frequency of an Element After Performing Operations II
namespace CompetitiveProgramming.LeetCode.MaximumFrequencyofanElementAfterPerformingOperationsII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxFrequency(int[] nums, int k, int numOperations)
    {
        int len = nums.Length;
        Dictionary<int, int> dict = new();
       
        Array.Sort(nums);

        int res = 0, i = 0, j = 0;
        foreach(int n in nums)
        {
            while(j < len && nums[j] <= n+k) 
            {
                if(!dict.ContainsKey(nums[j]))
                    dict.Add(nums[j], 1);
                else
                    dict[nums[j]]++;

                j++;
            }

            while(i < len && nums[i] < n-k)
            {
                if(--dict[nums[i]] == 0)
                    dict.Remove(nums[i]);
                    
                i++;
            }              

            int cur = Math.Min(j-i, dict[n]+numOperations);
            res = Math.Max(cur, res);
        }

        for(int p = 0, q = 0; q < len; q++)
        {
            while(p < len && nums[p] + 2*k <nums[q])
            {
                p++;
            }

            res = Math.Max(res, Math.Min(q-p+1, numOperations));
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
            ResultTester.CheckResult<int>(solution.MaxFrequency([1,4,5], 1, 2), 2),
            ResultTester.CheckResult<int>(solution.MaxFrequency([5,11,20,20], 5, 1), 2),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Frequency of an Element After Performing Operations II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}