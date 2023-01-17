using System;
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
}

