// Partition Array Into Three Parts With Equal Sum


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PartitionArrayIntoThreePartsWithEqualSum
{
    public class Solution
    {
        public static bool CanThreePartsEqualSum(int[] arr)
        {
            int sumOfMembers = arr.Sum();
            if(sumOfMembers%3 != 0)
                return false;

            int temp = 0;
            int count = 0;
            int targetSum = sumOfMembers/3;
            for(int i = 0; i < arr.Length; i++)
            {
                temp += arr[i];
                if(temp == targetSum)
                {
                    count++;
                    temp = 0;
                }
            }
            return count >= 3;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.CanThreePartsEqualSum(new int[]{0,2,1,-6,6,-7,9,1,2,0,1}), true),
                ResultTester.CheckResult<bool>(Solution.CanThreePartsEqualSum(new int[]{0,2,1,-6,6,7,9,-1,2,0,1}), false),
                ResultTester.CheckResult<bool>(Solution.CanThreePartsEqualSum(new int[]{3,3,6,5,-2,2,5,1,-9,4}), true),
            };
            return results;
        }
    }
}