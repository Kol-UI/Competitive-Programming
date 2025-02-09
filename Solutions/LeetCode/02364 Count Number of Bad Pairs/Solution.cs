// Count Number of Bad Pairs

namespace CompetitiveProgramming.LeetCode.CountNumberofBadPairs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long CountBadPairs(int[] nums)
    {
        long badPairsCount = 0;
        Dictionary<int,int> dictionary = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int diff = i - nums[i];
            int val = 0;
            if(dictionary.ContainsKey(diff))
            {
                val = dictionary[diff];
                dictionary[diff] += 1;
            }
            else dictionary.Add(diff, 1);
            badPairsCount += i - val;
        }
        return badPairsCount;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Number of Bad Pairs");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}