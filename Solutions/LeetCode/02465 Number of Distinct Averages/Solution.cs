// Number of Distinct Averages


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofDistinctAverages
{
    public class Solution
    {
        public static int DistinctAverages(int[] nums)
        {
            Array.Sort(nums);

            HashSet<int> unique = new();

            for (int i = 0; i < nums.Length / 2; ++i)
                unique.Add(nums[i] + nums[nums.Length - 1 - i]);

            return unique.Count;    
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.DistinctAverages(new int[]{4,1,4,0,3,5}), 2),
                ResultTester.CheckResult<int>(Solution.DistinctAverages(new int[]{1,100}), 1),
            };
            return results;
        }
    }
}