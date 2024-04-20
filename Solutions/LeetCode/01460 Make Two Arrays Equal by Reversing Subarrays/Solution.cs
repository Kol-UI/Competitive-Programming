// Make Two Arrays Equal by Reversing Subarrays

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MakeTwoArraysEqualbyReversingSubarrays
{
    public class Solution
    {
        public static bool CanBeEqual(int[] target, int[] arr)
        {
            Array.Sort(target);
            Array.Sort(arr);
        
            for(int i = 0; i < target.Length; i++)
            {
                if(target[i] != arr[i])
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.CanBeEqual(new int[]{1,2,3,4}, new int[]{2,4,1,3}), true),
                ResultTester.CheckResult<bool>(Solution.CanBeEqual(new int[]{7}, new int[]{7}), true),
                ResultTester.CheckResult<bool>(Solution.CanBeEqual(new int[]{3,7,9}, new int[]{3,7,11}), false),
            };
            return results;
        }
    }
}