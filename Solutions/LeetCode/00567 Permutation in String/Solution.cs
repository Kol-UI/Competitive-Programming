using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PermutationinString
{
    public class Solution
    {
        // Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
        // In other words, return true if one of s1's permutations is the substring of s2.

        // Example 1:

        // Input: s1 = "ab", s2 = "eidbaooo"
        // Output: true
        // Explanation: s2 contains one permutation of s1 ("ba").

        // Example 2:

        // Input: s1 = "ab", s2 = "eidboaoo"
        // Output: false
        
        public static bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;

            int[] bucket = new int[26];

            for(int i = 0; i < s1.Length; i++)
            {
                bucket[s1[i] - 'a']++;
                bucket[s2[i] - 'a']--;
            }

            if (IsValid(bucket))
                return true;

            for(int i = s1.Length; i < s2.Length; i++)
            {
                bucket[s2[i] - 'a']--;
                bucket[s2[i - s1.Length] - 'a']++;
                
                if (IsValid(bucket)) 
                    return true;
            }

            return false;
        }

        public static bool IsValid(int[] bucket)
        {
            for(int i = 0; i < 26; i++)
            {
                if (bucket[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class Test
    {
        public static bool[] TestValidTriangleNumber()
        {
            bool result1 = Solution.CheckInclusion("ab", "eidbaooo");
            bool result2 = Solution.CheckInclusion("ab", "eidboaoo");
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, true),
                ResultTester.CheckResult<bool>(result2, false)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Permutation in String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestValidTriangleNumber());
        }
    }
}