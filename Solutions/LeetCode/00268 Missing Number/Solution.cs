// Missing Number


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MissingNumber
{
    public class Solution
    {
        public static int MissingNumber(int[] nums)
        {
            int expectedSum = nums.Length * (nums.Length + 1) / 2;
            int actualSum = nums.Sum();
            return expectedSum - actualSum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MissingNumber(new int[]{3,0,1}), 2),
                ResultTester.CheckResult<int>(Solution.MissingNumber(new int[]{0,1}), 2),
                ResultTester.CheckResult<int>(Solution.MissingNumber(new int[]{9,6,4,2,3,5,7,0,1}), 8),
            };
            return results;
        }
    }
}