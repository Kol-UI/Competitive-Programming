// Minimum Number of Operations to Make Array XOR Equal to K


using System.Numerics;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumNumberofOperationstoMakeArrayXOREqualtoK
{
    public class Solution
    {
        public static int MinOperations(int[] nums, int k)
        {
            return BitOperations.PopCount((uint) nums.Aggregate(k, (current, num) => current ^ num));
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinOperations(new int[] {2,1,3,4}, 1), 2),
                ResultTester.CheckResult<int>(Solution.MinOperations(new int[] {2,0,2,0}, 0), 0),
            };
            return results;
        }
    }
}