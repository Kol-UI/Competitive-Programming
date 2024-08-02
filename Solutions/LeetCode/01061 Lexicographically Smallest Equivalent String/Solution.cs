using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LexicographicallySmallestEquivalentString
{
    public class Solution
	{
        //You are given two strings of the same length s1 and s2 and a string baseStr.

        //We say s1[i] and s2[i] are equivalent characters.

        //For example, if s1 = "abc" and s2 = "cde", then we have 'a' == 'c', 'b' == 'd', and 'c' == 'e'.
        //Equivalent characters follow the usual rules of any equivalence relation:

        //Reflexivity: 'a' == 'a'.
        //Symmetry: 'a' == 'b' implies 'b' == 'a'.
        //Transitivity: 'a' == 'b' and 'b' == 'c' implies 'a' == 'c'.
        //For example, given the equivalency information from s1 = "abc" and s2 = "cde", "acd" and "aab" are equivalent strings of baseStr = "eed", and "aab" is the lexicographically smallest equivalent string of baseStr.

        //Return the lexicographically smallest equivalent string of baseStr by using the equivalency information from s1 and s2.



        //Example 1:

        //Input: s1 = "parker", s2 = "morris", baseStr = "parser"
        //Output: "makkek"
        //Explanation: Based on the equivalency information in s1 and s2, we can group their characters as [m, p], [a, o], [k, r, s], [e, i].
        //The characters in each group are equivalent and sorted in lexicographical order.
        //So the answer is "makkek".
        //Example 2:

        //Input: s1 = "hello", s2 = "world", baseStr = "hold"
        //Output: "hdld"
        //Explanation: Based on the equivalency information in s1 and s2, we can group their characters as [h, w], [d, e, o], [l, r].
        //So only the second letter 'o' in baseStr is changed to 'd', the answer is "hdld".
        //Example 3:

        //Input: s1 = "leetcode", s2 = "programs", baseStr = "sourcecode"
        //Output: "aauaaaaada"
        //Explanation: We group the equivalent characters in s1 and s2 as [a, o, e, r, s, c], [l, p], [g, t] and[d, m], thus all letters in baseStr except 'u' and 'd' are transformed to 'a', the answer is "aauaaaaada".


        public static string SmallestEquivalentString(string s1, string s2, string baseStr)
        {
            char[] arr = new char[26];
            for (ushort i = 0; i < 26; ++i)
            {
                arr[i] = (char)('a' + i);
            }
            for (int i = 0; i < s1.Length; ++i)
            {
                char min = arr[s1[i] - 'a'];
                char max = arr[s2[i] - 'a'];
                if (max < min) (max, min) = (min, max);
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == max) arr[j] = min;
                }
            }
            return new string(baseStr.Select(x => arr[x - 'a']).ToArray());
        }
    }


    public class Test
    {
        public static bool[] TestLexicographicallySmallestEquivalentString()
        {
            // Case 1
            string Case1_s1 = "parker";
            string Case1_s2 = "morris";
            string Case1_baseStr = "parser";
            string Case1_1061_Result = Solution.SmallestEquivalentString(Case1_s1, Case1_s2, Case1_baseStr);

            // Case 2
            string Case2_s1 = "hello";
            string Case2_s2 = "world";
            string Case2_baseStr = "hold";
            string Case2_1061_Result = Solution.SmallestEquivalentString(Case2_s1, Case2_s2, Case2_baseStr);

            // Case 3
            string Case3_s1 = "leetcode";
            string Case3_s2 = "programs";
            string Case3_baseStr = "sourcecode";
            string Case3_1061_Result = Solution.SmallestEquivalentString(Case3_s1, Case3_s2, Case3_baseStr);

            string expected1 = "makkek";
            string expected2 = "hdld";
            string expected3 = "aauaaaaada";

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Case1_1061_Result, expected1),
                ResultTester.CheckResult<string>(Case2_1061_Result, expected2),
                ResultTester.CheckResult<string>(Case3_1061_Result, expected3)
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Title");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestLexicographicallySmallestEquivalentString());
        }
    }
}