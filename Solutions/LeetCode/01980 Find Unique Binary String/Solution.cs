// Find Unique Binary String

/*
Given an array of strings nums containing n unique binary strings each of length n, return a binary string of length n that does not appear in nums. If there are multiple answers, you may return any of them.

 

Example 1:

Input: nums = ["01","10"]
Output: "11"
Explanation: "11" does not appear in nums. "00" would also be correct.

Example 2:

Input: nums = ["00","01"]
Output: "11"
Explanation: "11" does not appear in nums. "10" would also be correct.

Example 3:

Input: nums = ["111","011","001"]
Output: "101"
Explanation: "101" does not appear in nums. "000", "010", "100", and "110" would also be correct.
*/

using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindUniqueBinaryString
{
    public class Solution
    {
        public static string FindDifferentBinaryString(string[] nums)
        {
            int length = nums.Length;
            StringBuilder number = new StringBuilder();
            
            for (int i = 0; i < length; i++)
            {
                number.Append(nums[i][i] == '1' ? '0' : '1');
            }
            
            return number.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string[] nums1 = {"01","10"};
            string[] nums2 = {"00","01"};
            string[] nums3 = {"111","011","001"};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.FindDifferentBinaryString(nums1), "11"),
                ResultTester.CheckResult<string>(Solution.FindDifferentBinaryString(nums2), "10"),
                ResultTester.CheckResult<string>(Solution.FindDifferentBinaryString(nums3), "000"),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Find Unique Binary String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}