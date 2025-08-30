// Most Frequent Number Following Key In an Array
namespace CompetitiveProgramming.LeetCode.MostFrequentNumberFollowingKeyInanArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MostFrequent(int[] nums, int key) 
    {
        var dict = new Dictionary<int,int>();

        for(var i = 0; i < nums.Length - 1;i++)
        {
            if(nums[i] == key)
            {
                if(!dict.ContainsKey(nums[i+1]))dict.Add(nums[i+1],0);
                dict[nums[i+1]]++;
            }
        }

        var ans = (-1,-1);

        foreach(var i in dict)
        {
            if(ans.Item1 < i.Value) ans = (i.Value,i.Key);
        }

        return ans.Item2;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MostFrequent(new int[]{1,100,200,1,100}, 1), 100),
            ResultTester.CheckResult<int>(solution.MostFrequent(new int[]{2,2,2,2,3}, 2), 2),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Most Frequent Number Following Key In an Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}