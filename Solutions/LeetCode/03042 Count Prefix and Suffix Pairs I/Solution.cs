// Count Prefix and Suffix Pairs I


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountPrefixandSuffixPairsI
{
    public class Solution
    {
        public static int CountPrefixSuffixPairs(string[] words)
        {
            int ans = 0;
            for (int i = 0; i < words.Length - 1; i++)
                for (int j = i + 1; j < words.Length; j++)
                    if (IsPrefixSuffix(words[i], words[j]))
                        ans++;
            return ans;
        }

        private static bool IsPrefixSuffix(string s0, string s1)
        {
            if (!s1.StartsWith(s0))
                return false;
            return s1.EndsWith(s0);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountPrefixSuffixPairs(new string[]{"a","aba","ababa","aa"}), 4),
                ResultTester.CheckResult<int>(Solution.CountPrefixSuffixPairs(new string[]{"pa","papa","ma","mama"}), 2),
                ResultTester.CheckResult<int>(Solution.CountPrefixSuffixPairs(new string[]{"abab","ab"}), 0),
            };
            return results;
        }
    }
}