// Decode Ways

/*
A message containing letters from A-Z can be encoded into numbers using the following mapping:

'A' -> "1"
'B' -> "2"
...
'Z' -> "26"
To decode an encoded message, all the digits must be grouped then mapped back into letters using the reverse of the mapping above (there may be multiple ways). For example, "11106" can be mapped into:

"AAJF" with the grouping (1 1 10 6)
"KJF" with the grouping (11 10 6)
Note that the grouping (1 11 06) is invalid because "06" cannot be mapped into 'F' since "6" is different from "06".

Given a string s containing only digits, return the number of ways to decode it.

The test cases are generated so that the answer fits in a 32-bit integer.

 

Example 1:

Input: s = "12"
Output: 2
Explanation: "12" could be decoded as "AB" (1 2) or "L" (12).

Example 2:

Input: s = "226"
Output: 3
Explanation: "226" could be decoded as "BZ" (2 26), "VF" (22 6), or "BBF" (2 2 6).

Example 3:

Input: s = "06"
Output: 0
Explanation: "06" cannot be mapped to "F" because of the leading zero ("6" is different from "06").
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DecodeWays
{
    public class Solution
    {
        public static int NumDecodings(string s)
        {
            var dp = Enumerable.Repeat(-1, 101).ToArray();
            return NumDecodingsRec(s, 0 , dp);
        }

        static int NumDecodingsRec(string s , int pos , int [] dp)
        {
            int way = 0;

            if(pos == s.Length ) return 1;

            if(s[pos] == '0') return 0;
            
            if(dp[pos] != -1) return dp[pos];
            
            way = NumDecodingsRec(s, pos+1, dp);
            
            if(pos < s.Length-1 && Convert.ToInt32(s.Substring(pos, 2)) <= 26)
            {
                way +=  NumDecodingsRec(s, pos+2, dp);
            }
            return dp[pos]= way;
        }
    }

    public class Test
    {
        public static bool[] TestDecodeWays()
        {
            int result1 = Solution.NumDecodings("12");
            int result2 = Solution.NumDecodings("226");
            int result3 = Solution.NumDecodings("06");

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 2),
                ResultTester.CheckResult<int>(result2, 3),
                ResultTester.CheckResult<int>(result3, 0)
            };
            return results;
        }
    }
}
