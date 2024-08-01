using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheIndexoftheFirstOccurrenceinaString
{
    public class Solution
    {
        //Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
        
        // Example 1:
        // Input: haystack = "sadbutsad", needle = "sad"
        // Output: 0
        // Explanation: "sad" occurs at index 0 and 6.
        // The first occurrence is at index 0, so we return 0.
        
        // Example 2:
        // Input: haystack = "leetcode", needle = "leeto"
        // Output: -1
        // Explanation: "leeto" did not occur in "leetcode", so we return -1.
        
        public static int StrStr(string haystack, string needle)
        {
            for(int i = 0; i < haystack.Length; i++)
            {
                var len = 0;
                for(int j = 0; j < needle.Length; j++)
                {                
                    if (i+len >= haystack.Length || haystack[i+len] != needle[j]) break;

                    len++;
                }

                if (len == needle.Length) return i;
            }

            return -1;
        }
    }


    public class Test
    {
        public static bool[] TestFindtheIndexoftheFirstOccurrenceinaString()
        {
            // Case 1
            string haystackCase1_28 = "sadbutsad";
            string needleCase1_28 = "sad";
            int result_Case1_28 = LeetCode.FindtheIndexoftheFirstOccurrenceinaString.Solution.StrStr(haystackCase1_28, needleCase1_28);

            // Case 2
            string haystackCase2_28 = "leetcode";
            string needleCase2_28 = "leeto";
            int result_Case2_28 = LeetCode.FindtheIndexoftheFirstOccurrenceinaString.Solution.StrStr(haystackCase2_28, needleCase2_28);

            // Case 3
            string haystackCase3_28 = "mississippi";
            string needleCase3_28 = "issip";
            int result_Case3_28 = LeetCode.FindtheIndexoftheFirstOccurrenceinaString.Solution.StrStr(haystackCase3_28, needleCase3_28);

            // Case 4
            string haystackCase4_28 = "a";
            string needleCase4_28 = "a";
            int result_Case4_28 = LeetCode.FindtheIndexoftheFirstOccurrenceinaString.Solution.StrStr(haystackCase4_28, needleCase4_28);

            // Case 5
            string haystackCase5_28 = "hello";
            string needleCase5_28 = "ll";
            int result_Case5_28 = LeetCode.FindtheIndexoftheFirstOccurrenceinaString.Solution.StrStr(haystackCase5_28, needleCase5_28);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result_Case1_28, 0),
                ResultTester.CheckResult<int>(result_Case2_28, -1),
                ResultTester.CheckResult<int>(result_Case3_28, 4),
                ResultTester.CheckResult<int>(result_Case4_28, 0),
                ResultTester.CheckResult<int>(result_Case5_28, 2)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Index of the First Occurrence in a String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestFindtheIndexoftheFirstOccurrenceinaString());
        }
    }
}