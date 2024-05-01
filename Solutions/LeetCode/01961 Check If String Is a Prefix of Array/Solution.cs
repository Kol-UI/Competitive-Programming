// Check If String Is a Prefix of Array

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CheckIfStringIsaPrefixofArray
{
    public class Solution
    {
        public static bool IsPrefixString(string s, string[] words)
        {
            for (int i = 0, lengthValue = 0; i < words.Length; i++)
            {
                if((lengthValue += words[i].Length) == s.Length) 
                    return s == string.Concat(words[..(i+1)]);
            }

            return false;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsPrefixString("iloveleetcode",new string[]{"i","love","leetcode","apples"}), true),
                ResultTester.CheckResult<bool>(Solution.IsPrefixString("iloveleetcode",new string[]{"apples","i","love","leetcode"}), false),
            };
            return results;
        }
    }
}