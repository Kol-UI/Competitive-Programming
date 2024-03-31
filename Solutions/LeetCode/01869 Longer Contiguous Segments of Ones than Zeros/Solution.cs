// Longer Contiguous Segments of Ones than Zeros


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongerContiguousSegmentsofOnesthanZeros
{
    public class Solution
    {
        public static bool CheckZeroOnes(string s)
        {
            if(s.Length == 0)
                return false;

            if(s.Length == 1 && s[0] == '1')
                return true;

            int maxZeroes = 0, maxOnes = 0, currZeroes = 0, currOnes = 0;
            int prev = s[0] - '0';
            
            for(int i = 1; i < s.Length; i++)
            {
                if(prev == s[i] - '0')
                {
                    if(prev == 1)
                        currOnes++;
                    else
                        currZeroes++;
                    maxOnes = Math.Max(maxOnes, currOnes);
                    maxZeroes = Math.Max(maxZeroes, currZeroes);
                }
                else
                {
                    currOnes = 0;
                    currZeroes = 0;
                }
                prev = s[i] - '0';
            }
            return (maxOnes > maxZeroes) ? true : false;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.CheckZeroOnes("1101"), true),
                ResultTester.CheckResult<bool>(Solution.CheckZeroOnes("111000"), false),
                ResultTester.CheckResult<bool>(Solution.CheckZeroOnes("110100010"), false),
            };
            return results;
        }
    }
}