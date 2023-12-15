using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FirstUniqueCharacterinaString
{
    public class Solution
	{
        //Given a string s, find the first non-repeating character in it and return its index.If it does not exist, return -1.

        //Example 1:

        //Input: s = "leetcode"
        //Output: 0

        //Example 2:

        //Input: s = "loveleetcode"
        //Output: 2

        //Example 3:

        //Input: s = "aabb"
        //Output: -1

        public static int FirstUniqChar(string s)
        {
            var distinctTest = s.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.Key).ToList<char>();
            if (distinctTest.Count > 0)
            {
                var c = s.ToCharArray().ToList<char>();
                return c.IndexOf(distinctTest[0]);
            }
            else
                return -1;
        }
    }

    public class Test
    {
        public static bool[] TestFirstUniqueCharacterinaString()
        {
            // Case 1
            string stringCase1_387 = "leetcode";
            int Case1_387_Result = Solution.FirstUniqChar(stringCase1_387);

            // Case 2
            string stringCase2_387 = "loveleetcode";
            int Case2_387_Result = Solution.FirstUniqChar(stringCase2_387);

            // Case 3
            string stringCase3_387 = "aabb";
            int Case3_387_Result = Solution.FirstUniqChar(stringCase3_387);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_387_Result, 0),
                ResultTester.CheckResult<int>(Case2_387_Result, 2),
                ResultTester.CheckResult<int>(Case3_387_Result, -1)
            };
            return results;
        }
    }
}

