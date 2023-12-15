// Longest Repeating Character Replacement

/*
You are given a string s and an integer k. You can choose any character of the string and change it to any other uppercase English character. You can perform this operation at most k times.

Return the length of the longest substring containing the same letter you can get after performing the above operations.

 

Example 1:

Input: s = "ABAB", k = 2
Output: 4
Explanation: Replace the two 'A's with two 'B's or vice versa.

Example 2:

Input: s = "AABABBA", k = 1
Output: 4
Explanation: Replace the one 'A' in the middle with 'B' and form "AABBBBA".
The substring "BBBB" has the longest repeating letters, which is 4.
There may exists other ways to achive this answer too.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestRepeatingCharacterReplacement
{
    public class Solution
    {
        public static int CharacterReplacement(string s, int k)
        {
            int left = 0,maxCount = 0, maxLength = 0;

            int[] counter = new int[26];

            for(int right = 0; right < s.Length; right++)
            {
                maxCount = Math.Max(maxCount, ++counter[s[right] - 'A']);
                
                if(right - left + 1 - maxCount > k)
                {
                    counter[s[left] - 'A']--;
                    left++;
                }

                maxLength = Math.Max(maxLength, right-left+1);
            }
            
            return maxLength;
        }
    }
    public class Test
    {
        public static bool[] TestLongestRepeatingCharacterReplacement()
        {
            string s1 = "ABAB";
            int k1 = 2;
            string s2 = "AABABBA";
            int k2 = 1;
            int result1 = Solution.CharacterReplacement(s1, k1);
            int result2 = Solution.CharacterReplacement(s2, k2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 4),
                ResultTester.CheckResult<int>(result2, 4)
            };
            return results;
        }
    }

}