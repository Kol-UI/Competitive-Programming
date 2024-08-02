using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.GreatestCommonDivisorofStrings
{
    public class Solution
    {
        // For two strings s and t, we say "t divides s" if and only if s = t + ... + t (i.e., t is concatenated with itself one or more times).

        // Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

        // Example 1:

        // Input: str1 = "ABCABC", str2 = "ABC"
        // Output: "ABC"

        // Example 2:

        // Input: str1 = "ABABAB", str2 = "ABAB"
        // Output: "AB"

        // Example 3:

        // Input: str1 = "LEET", str2 = "CODE"
        // Output: ""


        public static int gcd(int n1,int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return gcd(n2, n1 % n2);
            }   
        }
        
        public static string GcdOfStrings(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            if((str1 + str2).Equals(str2 + str1))
            {
                int index = gcd(len1, len2);
                return str1.Substring(0, index);
            }
            else
            {
                return "";
            }
        }
    }

    public class Test
    {
        public static bool[] TestGreatestCommonDivisorofStrings()
        {
            string str1_1 = "ABCABC"; string str2_1 = "ABC";
            string str1_2 = "ABABAB"; string str2_2 = "ABAB";
            string str1_3 = "LEET"; string str2_3 = "CODE";

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.GcdOfStrings(str1_1, str2_1), "ABC"),
                ResultTester.CheckResult<string>(Solution.GcdOfStrings(str1_2, str2_2), "AB"),
                ResultTester.CheckResult<string>(Solution.GcdOfStrings(str1_3, str2_3), "")
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1071");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestGreatestCommonDivisorofStrings());
        }
    }
}