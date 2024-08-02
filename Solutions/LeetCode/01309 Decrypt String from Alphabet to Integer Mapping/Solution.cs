// Decrypt String from Alphabet to Integer Mapping

/*
You are given a string s formed by digits and '#'. We want to map s to English lowercase characters as follows:

Characters ('a' to 'i') are represented by ('1' to '9') respectively.
Characters ('j' to 'z') are represented by ('10#' to '26#') respectively.
Return the string formed after mapping.

The test cases are generated so that a unique mapping will always exist.

 

Example 1:

Input: s = "10#11#12"
Output: "jkab"
Explanation: "j" -> "10#" , "k" -> "11#" , "a" -> "1" , "b" -> "2".

Example 2:

Input: s = "1326#"
Output: "acz"
*/

using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DecryptStringfromAlphabettoIntegerMapping
{
    public class Solution
    {
        public static string FreqAlphabets(string s)
        {
            StringBuilder str = new();
                for (int i = 0; i < s.Length;)
                {
                    if (i < s.Length - 2 && s[i + 2] == '#')
                    {
                        str.Append((char)('j' + (s[i] - '1') * 10 + s[i + 1] - '0'));
                        i += 3;
                    }
                    else
                    {
                        str.Append((char)('a' + (s[i] - '1')));
                        i++;
                    }
                }
            return str.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestDecryptStringfromAlphabettoIntegerMapping()
        {
            string s1 = "10#11#12";
            string s2 = "1326#";

            string result1 = Solution.FreqAlphabets(s1);
            string result2 = Solution.FreqAlphabets(s2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(result1, "jkab"),
                ResultTester.CheckResult<string>(result2, "acz")
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1309");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestDecryptStringfromAlphabettoIntegerMapping());
        }
    }
}