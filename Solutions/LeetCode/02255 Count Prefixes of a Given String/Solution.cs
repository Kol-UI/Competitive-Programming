// Count Prefixes of a Given String

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountPrefixesofaGivenString
{
    public class Solution
    {
        public static int CountPrefixes(string[] words, string s)
        {
            return words.Count(i => s.StartsWith(i));
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountPrefixes(new string[]{"a","a"}, "aa"), 2),
                ResultTester.CheckResult<int>(Solution.CountPrefixes(new string[]{"a","b","c","ab","bc","abc"}, "abc"), 3),
            };
            return results;
        }
    }
}