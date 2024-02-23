// Number of Unequal Triplets in Array


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofUnequalTripletsinArray
{
    public class Solution
    {
        public static int UnequalTriplets(int[] nums)
        {
            int count = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    for(int k = 0; k < nums.Length; k++)
                    {
                        if(nums[i] < nums[j] && nums[j] < nums[k]) count++;
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
                ResultTester.CheckResult<int>(Solution.UnequalTriplets(new int[]{4,4,2,4,3}), 3),
                ResultTester.CheckResult<int>(Solution.UnequalTriplets(new int[]{1,1,1,1,1}), 0),
            };
            return results;
        }
    }
}