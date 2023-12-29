// Count Pairs Whose Sum is Less than Target



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CountPairsWhoseSumisLessthanTarget
{
    public class Solution
    {
        public static int CountPairs(IList<int> nums, int target)
        {
            int count = 0;
            
            for(int i = 0; i < nums.Count; i++)
            {
                for(int j = i + 1; j < nums.Count; j++)
                {
                    int sum = nums[i] + nums[j];
                    if(sum < target)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountPairs(new int[]{-1,1,2,3,1}, 2), 3),
                ResultTester.CheckResult<int>(Solution.CountPairs(new int[]{-6,2,5,-2,-7,-1,3}, -2), 10),
            };
            return results;
        }
    }
}